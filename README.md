# cv-website
This is a website I developed using the Blazor framework, C# and some simple HTML & CSS. I wanted to create this website to demonstrate a project I worked on at University of which
you can see a demo on portfolio > monkeys on the hosted website down below.
```bash
https://danelyttinen.xyz/
```
## The monkeys project
This was originally a project which was just hosted 3 localhost servers, a fitness server, a monkeys server and the Client which would all communicate with eacother using HTTP requests.
Originally the fitness server will recieve a message from the client and store it, unbeknownst to the monkeys server it will generate a number of strings and run the genetic algorithm
to try and generate the string. The fitness server will send back a list of scores with their each calculated hamming distance of which the genetic algorithm will use the lowest
scored genome and use that as the parent genomre while creating child genomes by randomly replacing a string in that genome.
This was one of the more enjoyable and challenging projects I had worked on at Uni and since Blazor is a easy to learn and powerful webframework, I decided to try and host it 
for others to see.
## Hosting
Hosting the project was something completely new to me as I had never hosted anything online before, as I had some past knowledge with IIS and AWS though, I decided to host the
website on a EC2 instance with IIS. Originally I also found some difficulty with the servers communcating with the website client so I found a workaround by setting up a API
which is hosted on Azure to recieve the messages back from the monkeys server and send them through to the web client. The monkeys and fitness server I found to be best hosted
as Azure Functions as they didn't really need to do any work unless called upon by the Client which was cost efficient, simple to set up and maintain. Originally though, as the
fitness server needed the original string to be stored in the programme somewhere and as Azure functions are serverless I found to be in a bit of a roadblock. Through some research
though, I found out about durable entities which was the exact solution I was looking for, a way to store class like object information on a serverless instance. These two projects
can be found below
```bash
https://github.com/DaneLyttinen/FitnessAzure
https://github.com/DaneLyttinen/MonkeysApp
```

![image](https://user-images.githubusercontent.com/69489249/127830037-14d7dc4c-7621-4437-a011-6b0e78a0cce9.png)

