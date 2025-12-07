# How to

## git setup

**...create a new repository on the command line**

```sh
COOKIECUTTER_PROJECT_NAME=foobar
echo "# $COOKIECUTTER_PROJECT_NAME" >> README.md
git init
git add README.md
git commit -m "Initial commit"
git branch -M main
git remote add origin git@github.com:mattmc3/${COOKIECUTTER_PROJECT_NAME}.git
git push -u origin main
```

**...or push an existing repository from the command line**

```sh
COOKIECUTTER_PROJECT_NAME=foobar
git remote add origin git@github.com:mattmc3/${COOKIECUTTER_PROJECT_NAME}.git
git branch -M main
git push -u origin main
```

## dotnet commands

```
COOKIECUTTER_PROJECT_NAME=foobar
dotnet restore
cd ./src
dotnet new console -n ${COOKIECUTTER_PROJECT_NAME}
cd ../tests
dotnet new mstest -n ${COOKIECUTTER_PROJECT_NAME}.Tests
```

## References

- [project structure]
- [project structure 2]
- [license]
- [gitignore]
- [editorconfig]

[project structure]: https://gist.github.com/davidfowl/ed7564297c61fe9ab814
[project structure 2]: https://learn.microsoft.com/en-us/dotnet/core/porting/project-structure
[gitignore]: https://github.com/github/gitignore/blob/main/Dotnet.gitignore
[editorconfig]: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/code-style-rule-options
[license]: https://github.com/github/choosealicense.com/blob/gh-pages/_licenses/mit.txt
