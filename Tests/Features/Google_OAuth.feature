Feature: GoogleTask service 	
Authentication should be provided

@Sunny @Sanity
Scenario Outline: Create Task
Given a valid google user is logged in
When he requested task "<NewTaskTitle>" creation under taskList "<TaskListName>"
Then the task should be created

Examples:
| NewTaskTitle | TaskListName |
|1|Mir's list|
|2|Mir's list|
|3|Mir's list|
|4|Mir's list|



@Sunny @Sanity
Scenario Outline: Move Task
Given a valid google user is logged in
When he requested to move the task "<TaskTitle>" under taskList "<TaskListName>"
Then the task should be moved

Examples:
| TaskTitle | TaskListName |
|3|Mir's list      |
