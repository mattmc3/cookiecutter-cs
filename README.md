# cookiecutter-cs

🍪 My cookiecutter template for new C# projects

# Install

Make sure you have Python and pipx:

```sh
brew install python3
brew install pipx
```

`pipx` gets python apps and puts them in ~/.local/bin, so make sure ~/.local/bin is in your path.

```sh
# .zshrc
path+=($HOME/.local/bin(N))
```

## Usage

To use cookiecutter to make a new C# project, you can run cookiecutter via pipx:

```sh
pipx run cookiecutter gh:mattmc3/cookiecutter-cs
```

Or, you can just run cookiecutter directly from a local clone:

```sh
git clone git@github.com:mattmc3/cookiecutter-cs ~/Projects/mattmc3/cookiecutter-cs
cd ~/Projects/mattmc3
cookiecutter ~/Projects/mattmc3/cookiecutter-cs
# Answer questions...
cd my-new-project
git init
```

Then init the git repo:

```sh
PROJ=my-new-project
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin git@github.com:mattmc3/${PROJ}.git
git push -u origin main
```
