# 00003. Abstraction libraries should contain only simple classes

2024-08-07

## Status

__Accepted__

## Context

An abstraction library contains interface and class definitions that are used for data sharing and class interaction. The main reason
to define an abstraction class is to simplify testing and to seperate functionality from interfacing.

## Decision

The abstraction library contaions domain specific objects, structs and interfaces.

## Consequences

- All items in an abstraction class should be well defined and well documented
- Items cannot contain any functionality except for get/set properties
