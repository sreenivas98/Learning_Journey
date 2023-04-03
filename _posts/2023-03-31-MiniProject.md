---
title: Mini-Project Reflection
date: 2023-03-31
---

It was very fun and exciting to learn C# programming language. It's already been six weeks into the learning journey and writing some sample programs doesn't give you the expertise to pursue your career as a developer. So as a group of three people learning C#, we decided to build simple stand-alone application to query a weather API and return the current weather conditions and display the results in a form. There are few concepts that I learned previously which helped me work on this project and also there are few concepts I had to learn to complete this project successfully.

<h2>What skills/knowledge that I had learned earlier in the semester were useful in this project?</h2>
Object oriented programming concepts such as ***classes*** , instantiation of ***objects*** , ***inheritance*** , ***constructors*** and ***access specifiers*** are some of the concepts that I have learned prior to taking up this project have helped me in successfully building the devised application. I have been the person to create the user input form which prompts the user to select either zipcode or area and enter the input in a text box which queries the API and returns the response in JSON format. <a href="https://github.com/sreenivas98/Learning_Journey/blob/main/CodePractice/MiniProject/IndexForm.cs">IndexForm.cs</a> is the code I have written which executes different instructions based on the events triggered by the user on various components of the form. For example, in the below code an event called click is triggered and the specified instructions are executed when the button ***Clear*** is clicked which is on the form.

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
Writing regular expressions is one of the concept that I grasped during writing the validation code for the input from the user and ***Leave*** event of the textbox is another concept that i had to know about while designing the form. Usually, when we want to create a ***regex pattern*** for validation we search the internet to get the suitable regex and use that in our program, but I wanted to know various symbols used to write the regex I needed to validate zip codes of USA, so I first learned about some of the basic symbols in regex and tried various regex patterns until I wrote the suitable one I needed for my form validation. For example, I have written the below regex pattern to validate zip codes of USA.

```
^\d{5}(?:[-\s]\d{4})?$
```

In the above regex pattern ***^*** indicates that it is the start of the sequence or pattern and the ***$*** indicates the end of the sequence or pattern.

<h2>Challenges Faced</h2>
Being an intermediate user of github I have faced challenges while merging my brach code into the main repo. We have got many conflicts that we were not able to resolve from the github itself. We tried various methods such as removing the changes we made, removing some junk files and merging again but were not able to do so. I was not able to figure out why many junk files related to visual studio are being pushed to our braches automatically even though we delete them from the local repo. At last, we gave up as we don't have much time to push our codes and deleted the whole repository from gihub and started pushing our branches and merging them into main branch one after the other. I always beleived that if we are facing any kind of technical problem, the best way to solve it is cleanup and start from the first, this problem and the method we followed to resolve it proved my point to me. But this solution doesn't work everytime as it can impact others work and create chaos as everything is cleaned up. 

The other important challenge that I faced in terms of writing the code is finding out the exact event to trigger when a text is changed in the textbox to perform my validation. I have stated this as one of my challenges because I have been using the event ***TextChanged*** if I needed some validation to be performed when a text is changed in a textbox and couldn't figure out why it was validating only when I start entering something and enter any one character. Then I realised even if we change only one character that means the text has changed, so, I needed to find a suitable event that allows the user to enter his complete input and then validates the input. While going through all the events of textbox I found the event ***Leave*** which allows user to enter the complete input and validates the input when the textbox becomes inactive. This resolved my second challenge.

<h2>Possible future enhancements</h2>
As we have a limited amount time we mostly focussed on taking either zip code or area name as input from the user and gets weather data such as temperature, wind speed, wind direction, etc. and displays it onto the form. There is scope for futher development like providing more customization options to the user. For example, the API has the ability to provide a map from which the user can choose a point of interest to get the weateher forecast at that location and we could include graphics to represent various information being showed in the respnse form.

