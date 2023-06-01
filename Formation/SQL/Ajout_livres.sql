BEGIN TRANSACTION;
DELETE FROM Authors;
DELETE FROM Books;
-- Authors
INSERT INTO Authors (Id, LastName, FirstName, BirthDate, CreatedDate, UpdatedDate) VALUES
(1, 'Rowling', 'J.K.', '1965-07-31', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(2, 'Martin', 'George R.R.', '1948-09-20', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(3, 'Tolkien', 'J.R.R.', '1892-01-03', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(4, 'Dickens', 'Charles', '1812-02-07', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(5, 'Austen', 'Jane', '1775-12-16', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(6, 'Shakespeare', 'William', '1564-04-23', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(7, 'Orwell', 'George', '1903-06-25', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(8, 'Hemingway', 'Ernest', '1899-07-21', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(9, 'Fitzgerald', 'F. Scott', '1896-09-24', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(10, 'Salinger', 'J.D.', '1919-01-01', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

-- Books
INSERT INTO Books (Id, Title, AuthorId, Description, PublicationDate, CreatedDate, UpdatedDate) VALUES
(1, 'Harry Potter and the Philosopher''s Stone', 1, 'A young boy discovers he is a wizard.', '1997-06-26', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(2, 'A Game of Thrones', 2, 'First book in A Song of Ice and Fire series.', '1996-08-01', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(3, 'The Lord of the Rings', 3, 'Epic high fantasy novel.', '1954-07-29', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(4, 'A Tale of Two Cities', 4, 'A novel set in London and Paris before and during the French Revolution.', '1859-12-01', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(5, 'Pride and Prejudice', 5, 'A romantic novel of manners.', '1813-01-28', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(6, 'Romeo and Juliet', 6, 'Tragedy about two young star-crossed lovers.', '1597-01-01', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(7, '1984', 7, 'Dystopian novel set in Airstrip One, a province of the superstate Oceania in a world of perpetual war.', '1949-06-08', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(8, 'The Old Man and The Sea', 8, 'The last major work of fiction by Hemingway that was published during his lifetime.', '1952-09-01', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(9, 'The Great Gatsby', 9, 'A 1925 novel written by American author F. Scott Fitzgerald.', '1925-04-10', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP),
(10, 'The Catcher in the Rye', 10, 'A novel about adolescent alienation and loss of innocence.', '1951-07-16', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);

COMMIT;
