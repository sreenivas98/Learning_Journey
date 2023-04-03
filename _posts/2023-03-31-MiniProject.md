---
title: Mini-Project Reflection
date: 2023-03-31
---

It was very fun and exciting to learn C# programming language. It's already been six weeks into the learning journey and writing some sample programs doesn't give you the expertise to pursue your career as a developer. So as a group of three people learning C#, we decided to build simple stand-alone application to query a weather API and return the current weather conditions and display the results in a form. There are few concepts that I learned previously which helped me work on this project and also there are few concepts I had to learn to complete this project successfully.

<h2>What skills/knowledge that I had learned earlier in the semester were useful in this project?</h2>
Object oriented programming concepts such as classes, instantiation of objects, inheritance, constructors and access specifiers are some of the concepts that I have learned prior to taking up this project have helped me in successfully building the devised application. I have been the person to create the user input form which prompts the user to select either zipcode or area and enter the input in a text box which queries the API and returns the response in JSON format. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/MiniProject/IndexForm.cs">IndexForm.cs</a> is the code I have written which executes different instructions based on the events triggered by the user on various components of the form. For example, in the below code an event called click is triggered and the specified instructions are executed when the button ***Clear*** is clicked which is on the form.

```
        private void Clear_Click(object sender, EventArgs e)
        {
            radioZipCode.Checked = false;
            radioCity.Checked = false;
            zipCode.Text = string.Empty;
            city.Text = string.Empty;
        }
```

The above code states that if the ***Clear*** button is clicked the radio buttons and text boxes are cleared. We can change various properties of the components from the code itself such as visibility, Enabled, Text, etc. 

<h2>What additional skills/knowledge I had to learn to complete your tasks?</h2>
Writing regular expressions is one of the concept that I grasped during writing the validation code for the input from the user and *

<h2>Challenges Faced</h2>


<h2>Possible future enhancements</h2>
As we have a limited amount time we mostly focussed on taking either zip code or area name as input from the user and gets weather data such as temperature, wind speed, wind direction, etc. and displays it onto the form. There is scope for futher development like providing more customization options to the user. For example, the API has the ability to provide a map from which the user can choose a point of interest to get the weateher forecast at that location and we could include graphics to represent various information being showed in the respnse form.

