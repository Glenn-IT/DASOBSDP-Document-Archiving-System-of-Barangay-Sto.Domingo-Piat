# Version Control — DAS Barangay Sto. Domingo, Piat

## Rollout Schedule

| Version | Feature Unlocked | Forms/Panels Unlocked | Still Gated |
|---------|-----------------|----------------------|-------------|
| v1.00 | Login / Forgot Password | `LoginForm`, `AdminForgotPasswordForm`, `UserForgotPasswordForm` | Admin Dashboard, User Dashboard, all panels |
| v1.01 | Admin: Dashboard + Archive List | `AdminDashboardForm`, `AdminArchiveListPanel`, `AdminNewDocumentForm`, `AdminUpdateDocumentForm`, `AdminDeleteDocumentForm` | Admin Users, Activity Logs, Profile; entire User side |
| v1.02 | Admin: Users Management | `AdminUsersListPanel`, `AdminAddAccountForm`, `AdminUpdateAccountForm`, `AdminDeleteUserForm` | Admin Activity Logs, Profile; entire User side |
| v1.03 | Admin: Activity Logs | `AdminActivityLogsPanel` | Admin Profile; entire User side |
| v1.04 | Admin: View Profile | `AdminViewProfilePanel` | Entire User side |
| v1.05 | User: Dashboard | `UserDashboardForm`, `UserDashboardPanel` | User Upload, Search Archive, Profile |
| v1.06 | User: Upload Document | `UserUploadDocumentPanel` | User Search Archive, Profile |
| v1.07 | User: Search Archive | `UserSearchArchivePanel`, `UserArchiveListPanel`, `UserDocumentViewForm`, `UserDeleteDocumentForm` | User Profile |
| v1.08 | User: View Profile (Full System) | `UserViewProfilePanel` | — |

---

## Under Construction Strategy

Locked features display an **UnderConstructionPanel** inside `pnlMainContent` — the same content area used by real panels. This means:

- The sidebar and app shell remain visible, showing the full layout to the audience
- Clicking a locked nav button replaces the content area with the Under Construction panel
- `CURRENT_VERSION` in `Helpers/Constants.vb` controls the version label displayed
- When a version is unlocked, the gate block is removed from the relevant button handler and `CURRENT_VERSION` is updated

**Gate pattern used in button click handlers:**
```vb
' GATE — remove when unlocking for vX.XX
LoadPanel(New UnderConstructionPanel())
HighlightButton(btnXxx)
lblPageTitle.Text = "Feature Name"
Return
' END GATE
```

---

## Git Commands Per Version

```bash
# Stage changed files
git add <file1> <file2>

# Commit
git commit -m "feat: implement vX.XX - unlock [Feature Name]"

# Tag and push
git tag vX.XX
git push origin master
git push origin vX.XX
```

---

## How Git Tags Work

Each version is a **permanent snapshot** via a lightweight tag. Tags point to a specific commit hash and never move, so you can always check out `v1.02` and see exactly what the system looked like at that presentation.

```bash
# Check out a specific version
git checkout v1.02

# Return to latest
git checkout master
```

---

## GitHub Release Tags

| Version | Tag Name | Commit Hash |
|---------|----------|-------------|
| v1.00 | v1.00 | |
| v1.01 | v1.01 | |
| v1.02 | v1.02 | |
| v1.03 | v1.03 | |
| v1.04 | v1.04 | |
| v1.05 | v1.05 | |
| v1.06 | v1.06 | |
| v1.07 | v1.07 | |
| v1.08 | v1.08 | |

*Hashes filled after all versions are pushed.*

---

## When a Prof or Client Requests Changes After a Presentation

```bash
# Fix on master first
git checkout master
git add <changed files>
git commit -m "feat: update [form] per feedback"
git push origin master

# Re-point the tag to the new commit
git tag -d vX.XX
git push origin :refs/tags/vX.XX
git tag vX.XX
git push origin vX.XX
```
