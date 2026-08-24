# Plugin.Maui.PulsingDots

A three-dot "waiting" indicator for .NET MAUI — each dot pulses opacity and
scale on a 1.2s loop, staggered 150ms apart, giving a soft breathing effect
instead of a spinner.

This repo is **just a sample app**, not a library. `PulsingDots` doesn't need
to be one: it's built entirely from `Shape` (`Ellipse`) and MAUI's built-in
`Animation`/`Commit` API — no custom `Handler`, no `Platforms/` folder, no
`ConfigureMauiHandlers` registration. Copy
[`Controls/PulsingDots.xaml`](Plugin.Maui.PulsingDots/Controls/PulsingDots.xaml)
+
[`Controls/PulsingDots.xaml.cs`](Plugin.Maui.PulsingDots/Controls/PulsingDots.xaml.cs)
into any MAUI project and it runs unmodified on every target MAUI supports —
Android, iOS, Mac Catalyst, Windows, Tizen.

That's the point of this sample: compare it against
[`Plugin.Maui.PullToRefresh`](../Plugin.Maui.PullToRefresh), a sibling repo
for a control that genuinely *needs* per-platform native handlers (gesture
interception below the MAUI layer). `PulsingDots` needs none of that — it's a
demonstration of how far the pure cross-platform layer goes before you ever
have to drop into a `Handler`.

## Running the sample

```bash
cd Plugin.Maui.PulsingDots
dotnet build -f net10.0-android   # or -f net10.0-ios
```

The project currently targets `net10.0-android` and `net10.0-ios` (what's
installed in this environment). Add `net10.0-maccatalyst` /
`net10.0-windows10.0.19041.0` back to `<TargetFrameworks>` in the `.csproj` if
you have those workloads — no code changes needed, per the point above.

## What the sample shows

- **Basic** — the control on its own, started/stopped via `IsRunning`.
- **Color variants** — the same control, `DotColor` bound differently each
  time.
- **Status-chip swap** — the real usage pattern it was built for: a status
  chip that shows `PulsingDots` in place of its label while data is loading,
  instead of flashing stale text.

## API

```csharp
public class PulsingDots : ContentView
{
    public Color DotColor { get; set; }  // bindable, defaults to Colors.Gray
    public bool IsRunning { get; set; }   // bindable, defaults to false
}
```

```xml
<controls:PulsingDots DotColor="#5B80C1" IsRunning="{Binding IsLoading}" />
```

## License

MIT — see [LICENSE](LICENSE).
