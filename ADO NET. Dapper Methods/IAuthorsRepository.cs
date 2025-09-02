

interface IAuthorsRepository
{
      Author AddAuthor(Author author);

    void AddAuthors(IEnumerable<Author> authors);

    Author GetAuthorById(int id);
    IEnumerable<Author> GetAuthors();

    void RemoveAuthorById(int id);
    void RemoveAuthorsById(int[] ids);
    void UpdateAuthor(Author author);
}

