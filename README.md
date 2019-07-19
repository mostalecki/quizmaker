# quizmaker
Quizmaker is a part of a IV semester group side-project. It allows you to create multiple choice text-quizzes and save them as json files, or load existing quizzes and edit them. It's designed to be used with [this client](https://github.com/dawpolak/quiz-client).\
It was built using Windows Forms, according to MVP design pattern.\
<br>
This is a sample json data containing a quiz with 2 questions, 4 answers each:
```json
{
  "title": "Sample quiz",
  "totalPoints": 8,
  "questions": [
    {
      "text": "What's the capital of Thailand?",
      "answers": [
        {
          "text": "Hanoi",
          "isCorrect": false
        },
        {
          "text": "Bangkok",
          "isCorrect": true
        },
        {
          "text": "Pattaya",
          "isCorrect": false
        },
        {
          "text": "Phnom Penh",
          "isCorrect": false
        }
      ],
      "points": 5
    },
    {
      "text": "Which of the following astronauts have walked the Moon?",
      "answers": [
        {
          "text": "Buzz Aldrin",
          "isCorrect": true
        },
        {
          "text": "Chris Hadfield",
          "isCorrect": false
        },
        {
          "text": "Michael Collins",
          "isCorrect": false
        },
        {
          "text": "Neil Armstrong",
          "isCorrect": true
        }
      ],
      "points": 3
    }
  ]
}
```
