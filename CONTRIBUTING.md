# Contributing

Thank you for your interest in contributing to **simpleCRUD**!
Contributions are welcome. Since this project is meant as a learning resource, changes that keep the code easy to read and follow are especially appreciated.

## Development workflow

1. **Fork the repository**
   - Go to [nncast/vb.net-simple-crud](https://github.com/nncast/vb.net-simple-crud).
   - Click the **Fork** button in the top-right corner to create a copy under your GitHub account.
   - Clone your fork locally:
     ```bash
     git clone https://github.com/<your-username>/vb.net-simple-crud.git
     cd vb.net-simple-crud
     ```
   - Add the original repository as an upstream remote so you can sync changes:
     ```bash
     git remote add upstream https://github.com/nncast/vb.net-simple-crud.git
     ```

2. **Create a branch** from `main` in your fork:
   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make your changes**, then commit and push to your fork:
   ```bash
   git push origin feature/your-feature-name
   ```

4. **Open a pull request** against `nncast/vb.net-simple-crud:main`.

## Before you submit

- Keep commit messages clear and descriptive.
- Avoid committing build output (`bin/`, `obj/`), user files (`*.suo`, `*.user`), or your own connection string.
- If you add or change behavior, update relevant documentation.
- Keep every query parameterized — go through `GetQuery` / `SetQuery` in `Conn.vb`, never string-concatenate user input into SQL.
- If you change a table, update `database/dbstudent.sql` and the [Database](README.md#database) section of the README.
- Build the solution and try the forms you changed against a local MySQL database (see [`README.md`](README.md#setup-and-run-instructions)).

## Code style

- Follow the existing project conventions.
- Prefer small, reviewable changes.
- Do not add unrelated formatting changes.

## Pull requests

Pull requests should include:

- a short summary of the change
- any relevant context or motivation
- testing steps or validation performed

## Security

Do not commit sensitive values such as database passwords or private connection strings.

For security reports, follow [SECURITY.md](https://github.com/nncast/vb.net-simple-crud/blob/main/SECURITY.md).
