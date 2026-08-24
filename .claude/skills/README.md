# .NET / MAUI development skills

These skills are vendored from two upstream repos to give Claude Code
on-demand, expert-level guidance while working in this .NET MAUI repo. They
load automatically when a prompt matches their topic — no manual selection
needed. This directory is gitignored (local-only, not committed).

## Sources

- [davidortinau/maui-skills](https://github.com/davidortinau/maui-skills) —
  `maui-*` feature skills and `ux-*` medium-specific reasoning skills.
  The `xamarin-*-migration` skills from upstream were left out since this app
  isn't being migrated from Xamarin.Forms.
- [dotnet/skills](https://github.com/dotnet/skills) — the `dotnet-maui`,
  `dotnet-msbuild`, `dotnet-nuget`, `dotnet-test`, and `dotnet-advanced`
  plugins (picked for relevance: this repo is a net10.0 MAUI app targeting
  Android/iOS, built via MSBuild/Azure Pipelines, tested with xUnit v3).

### Overlap between the two sources

`dotnet/skills`' `dotnet-maui` plugin ships 7 skills with the same names as
skills already vendored from `davidortinau/maui-skills` (`maui-theming`,
`maui-shell-navigation`, `maui-app-lifecycle`, `maui-collectionview`,
`maui-data-binding`, `maui-dependency-injection`, `maui-safe-area`), but
different content. Per a deliberate choice, **the `dotnet/skills` (official
.NET org) versions of these 7 win** and replaced the `davidortinau/maui-skills`
originals. `dotnet-maui-doctor` (the one non-duplicate skill in that plugin)
was added alongside them.

To pick up upstream updates, re-copy the relevant `skills/*` directories from
each source repo, re-applying the same overlap resolution.

## License

- `LICENSE-maui-skills` — MIT, Copyright (c) 2026 David Ortinau.
- `LICENSE-dotnet-skills` — MIT, Copyright (c) .NET Foundation and Contributors.
