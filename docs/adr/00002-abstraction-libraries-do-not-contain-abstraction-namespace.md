# 00002. Abstraction libraries do not contain abstraction namespace

2024-08-07

## Status

__Accepted__

## Context

An abstraction library contains interface and class definitions that are used for data sharing and class interaction. When implementing
classes or methods, it's interface or DTO-classes should be in the same namespace definition.

## Decision

Although it is best practice to add items in the namespace indicated by the project name, but for this project, the `abstraction`
namespace is not included.

## Consequences

- All items in an abstraction class should be well defined and well documented
- Items cannot contain any functionality except for get/set properties
