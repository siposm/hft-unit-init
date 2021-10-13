# Read me

Steps:

- add test methods
- use TDD aproach to modify logic's methods based on what the test needs
  - `ChangeBlogTitle` » check new string (null or empt string)
  - `GetBlogById` » check if id is not outside the limits

Homework / extra steps to do:
- extend `GetBlogById`'s id check to cover negative values
- add some kind of service / lookup array / API endpoint which can be called to get forbidden words, and compare the words to that collection (if it contains the word it means that it can't be used » exception)
- add and create dedicated `Exception` classes based on what is the problem
- create additional non-crud methods in the `BlogLogic` and write unit tests for those
- add exta logic methods to the `CommentLogic` and write tests for those
