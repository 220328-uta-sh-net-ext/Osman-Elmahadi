## History os Linux
- Linux began in 1991 as a personal project by Finnish student Linus Torvalds.
- The resulting Linux kernel has been marked by constant growth throughout its history. 

![image](https://user-images.githubusercontent.com/102450747/160728198-97da57e3-d8ab-42ff-8572-efad21b53b3d.png))

## History of Shell 
### What is Shell?
![alt text](https://www.subpng.com/png-btyu4f/)


Shell is a language that is used within the Unix system, so in human body interaction ; it's like the brain understanding English or whatever language that you're familiar with. These are scripting languages that are used for :
File Manipulation like “ save” or “del”
Printing Text like “echo”
Program Execution like “run” 

An example of this is  Bash ssh ; something similar to the process of interacting with git through the terminal.
![alt text](https://miro.medium.com/max/1400/1*iOPDTLUlV5ASMVRhizLNRw.png)



*So why do we use Markdown format?*
Markdown is a text syntax that allows easy readability without having so many tags like in HTML, which creates a prose language.  The benefit of using markdown is that it allows you to convert HTML easily with “plugins”. It's also easy to read in raw text files, such as in a terminal editor which later on will be useful.  

## Getting Started with Shell Programing

- Create a file using a vi editor(or any other editor). Name script file with extension . sh.
- Start the script with #! /bin/sh.
- Write some code.
- Save the script file as filename.sh.
- For executing the script type bash filename.sh.

## Shell Command 
- echo: move some data, usually text into a file.
- cat: is veryful to see every thing inside a files. 
- nano:Replace filename with the name of the file you want to edit.
- grep:used to search text and strings in a given file.
- mkdir:make directory 
- touch: create blank files.
- cd: Used to change the directory.
- ls: listing contents in extended form 
- which:to search and locate the list of files and directories based on conditions you specify for files that match the arguments.
- find:Find files that were changed during a certain period ·
- pwd:present working directory.


### Variables & Environment
Some Unix Shell scripting(Similar to terminal commands)
- ‘$HOME’ : **Pathname** 
- ‘$PATH’ : **List of commands to search** 
- ‘$SHELL’ : **Pathname  to your login shell**
- ‘$TERM’ : **Type of terminal your using** 

#### * Examples for Public & Private Variables *

* Public Variables * 
- ‘#!/bin/sh’
- ‘NAME=Revature’
- ‘Echo $NAME’

* Private Variables * 
- ‘#!/bin/sh’
- ‘NAME = Revature’
- ‘Readonly NAME’

There are also conditional statements like 
* (“If then statements”) *
- ‘for’ “constraints”
- ‘do’ “execution”
-‘done’ 

* (“Do while statement”) *
- ‘while’ “constraint”
- ‘do’ “execution”
- ‘done’ 








