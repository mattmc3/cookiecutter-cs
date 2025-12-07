.DEFAULT_GOAL := help
.PHONY: help all clean build release test pretty outdated

##? help: Show this help
help:
	@echo 'Usage: make [target]'
	@echo ''
	@echo 'Targets:'
	@grep -E '^##\? ' $(MAKEFILE_LIST) | sed 's/##? /  /' | column -t -s ':'

##? all: Clean, build, and test
all: clean build test

##? clean: Clean build artifacts
clean:
	dotnet clean
	find . -path ./tools -prune -o -path ./bin -prune -o -type d \( -name bin -o -name obj \) -prune -exec rm -rf {} +

##? build: Build the project
build:
	dotnet build

##? build: Build the project for release
release:
	dotnet build --configuration Release

##? test: Run unit tests
test:
	dotnet test

##? pretty: Format the code
pretty:
	dotnet format

##? outdated: List outdated packages
outdated:
	dotnet list package --outdated
