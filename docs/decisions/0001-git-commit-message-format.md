---
status: accepted
date: 2024-04-24
---

# Git Commit Message Format

## Context and Problem Statement

Git commit messages are often inconsistent in their format and content.
This can make it difficult to understand the history of a project,
and the changes that have been made over time.

Instead, we want to standardize the format of commit messages to make them
more readable and useful, as well as allow for the automation of processes
such as versioning and the generation of release notes.

However, such rules can easily become burdensome and lead to bikeshedding.
Rather than enforcing a strict format, we want to encourage the use of a
common standard and provide tooling to help developers follow it
(while also allowing for the possibility that some developers might not).

## Decision Outcome

**Chosen option:**
[Conventional Commits](https://www.conventionalcommits.org) gives us
the kind of structure we're looking for in our commit messages.
It's also broadly adopted in the industry and has tool support.
By providing a template for commit messages, we can promote consistency
while not being too tyrannical about it. While automation of releases is the
goal, each step should be overridable if needed to correct for any commit
messages that don't follow the correct pattern.

Additional information:

- [Blog post](https://medium.com/neudesic-innovation/conventional-commits-a-better-way-78d6785c2e08)
  by Michael Collins
- [Blog post](https://julien.ponge.org/blog/the-power-of-conventional-commits/)
  by Julien Ponge
- [Git Gist](https://gist.github.com/qoomon/5dfcdf8eec66a051ecd85625518cfd13)
  by Bengt Brodersen
