# Defect Report

####  * A defect report is a document that describes a problem or issue found during software testing or development. 

#### * It is also known as a bug report or an issue report.

#### * Developers can check this defect report, understand the problem & its solution and make improvements accordingly.

#### * QA testers create a defect report to test & analyze each functionality and note it in the report.

#### * It requires lots of effort and information to write a detailed defect report and deliver it to developers.

So the primary purpose of a good defect report is to identify the anomalies in the project and inform developers with a well-organized structure.

# Defect Report Template

## Defect ID  :
 
####  A unique identification number is used to identify the number of defects in the report.

## Defect Description (Description of problem):

####  This should be a clear and concise description of the problem that was encountered, including any error messages or other relevant information.

## Environment:

####  This section should include details about the environment in which the issue occurred, such as the operating system, browser, hardware, or any other relevant information.

## Status :

####  This is the current status of the defect report, such as "new," "in progress," or "resolved."

## Version:

#### Show the current version of the application where the defect was found. 

## Action Steps:

#### It shows the step-by-step action taken by an end user or QA testers that shows results as the defect. 

## Severity:

#### It describes the impact of the defect on the application. Each defect has a different severity level, and it’s important to note it in detail.

### Levels of Severity:

### Low: These bugs can be resolved once and don’t affect the performance again.  
### Medium: Some minor defects that are easy to resolve and affect less. 
### High: These bugs can affect the result of the application and need to be resolved. 
#### Critical: In the critical stage, bugs heavily affect the performance and end goal. Like crashing, system freezing, and restarting repeatedly.

## Priority: 

#### This is an assessment of how quickly the problem needs to be fixed, based on its severity and other factors.

##  Expected Result :

#### What results are expected as per the requirements when performing the action steps mentioned.  

## Actual Result :

#### What results are actually showing up when performing the action steps


# Reporting Defects Effectively:

####  It is essential that you report defects effectively so that time and effort is not unnecessarily wasted in trying to understand and reproduce the defect. Here are some guidelines:

## Be specific:

#### * Specify the exact action: 
  #### Instead of just saying “Generate the financial report.”, you might want to say “(1) Go to Reports page. (2) Select ‘Financial Report’. (3) Click ‘Generate'”
#### * In case of multiple paths, mention the exact path you followed: Do not say something like “If you do ‘A and X’ or ‘B and Y’ or ‘C and Z’, you get D.” Understanding all the paths at once will be difficult. Instead, say “Do ‘A and X’ and you get D.” You can, of course, mention elsewhere in the report that “D can also be got if you do ‘B and Y’ or ‘C and Z’.”
#### * Do not use vague pronouns: Do not say something like “In ApplicationA, open X, Y, and Z, and then close it.” What does the ‘it’ stand for? ‘Z’ or, ‘Y’, or ‘X’ or ‘ApplicationA’?”

## Be detailed:

#### Provide more information (not less). In other words, do not be lazy. Developers may or may not use all the information you provide but they sure do not want to beg you for any information you have missed.

## Be objective:

#### Do not make subjective statements like “This is a lousy application” or “You fixed it real bad.”
#### Stick to the facts and avoid the emotions.

## Reproduce the defect:

#### Do not be impatient and file a defect report as soon as you uncover a defect. Replicate it at least once more to be sure. (If you cannot replicate it again, try recalling the exact test condition and keep trying. However, if you cannot replicate it again after many trials, finally submit the report for further investigation, stating that you are unable to reproduce the defect anymore and providing any evidence of the defect if you had gathered. )

## Review the report:

#### Do not hit ‘Submit’ as soon as you write the report. Review it at least once. Remove any typos.