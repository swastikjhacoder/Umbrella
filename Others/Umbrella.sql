create database Umbrella

use Umbrella

create table GlobalSettings
(decimalentry Varchar(250),
qntyfield integer,
pricefield integer,
standardfield integer,
option1 Varchar(250),
option2 Varchar(250),
option3 Varchar(250),
option4 Varchar(250),
option5 Varchar(250),
performance1 Varchar(250),
performance2 Varchar(250),
performance3 Varchar(250),
performance4 Varchar(250),
itementry Varchar(250),
dataentry1 Varchar(250),
dataentry2 Varchar(250),
dataentry3 Varchar(250),
partnersecurity Varchar(250))

select * from GlobalSettings 

create table Users
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
userno varchar(250),
userrole varchar(250),
userid varchar(250),
userpasswd varchar(250),
useraccess varchar(250),
employeeinfo varchar(250),
employeecard varchar(250),
attendances varchar(250),
idcard varchar(250),
notices varchar(250),
studentcontrol varchar(250),
backuprestore varchar(250),
importexport varchar(250),
studentinfo varchar(250),
studentcard varchar(250),
preadmission varchar(250),
admission varchar(250),
registration varchar(250),
feesterms varchar(250),
bankinginfo varchar(250),
feescollection varchar(250),
discount varchar(250),
incomeexpenditure varchar(250),
accounting varchar(250),
financialloan varchar(250),
coursesubject varchar(250),
examination varchar(250),
progressreport varchar(250),
marksheet varchar(250),
messenger varchar(250),
globalaccess varchar(250),
alumni varchar(250),
certificates varchar(250),
purchaseorder varchar(250),
inventory varchar(250),
salesinvoice varchar(250),
games varchar(250),
bookrecords varchar(250),
charges varchar(250),
issuebooks varchar(250),
returnbooks varchar(250),
payrollsystem varchar(250),
payrollperiodic varchar(250),
payrollpf varchar(250),
institutedefault varchar(250),
librarydefault varchar(250),
payrolldefault varchar(250),
revenueyeartodate varchar(250),
yearend varchar(250))

select * from Users

create table UserCrystalReport
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
crystalreport Varchar(250),
crystalreportid Varchar(250))

select * from UserCrystalReport

create table InstituteIndex
(InsID varchar(250))

select * from InstituteIndex

create table Indexx
(InsID varchar(250),
empid varchar(250),
hiredempid varchar(250),
noticeid varchar(250),
idserial varchar(250),
admissionsl varchar(250),
preadmissionsl varchar(250),
sturegid varchar(250),
monthlyid varchar(250),
lateid varchar(250),
othersid varchar(250),
libraryid varchar(250),
examfeesid varchar(250),
yearlyid varchar(250),
discountid varchar(250),
financialid varchar(250),
depositid varchar(250),
examid varchar(250),
onlinexmid varchar(250),
assignmentid varchar(250),
markid varchar(250),
certificateid varchar(250),
progressid varchar(250),
controlid varchar(250),
inventoryid varchar(250),
purchaseid varchar(250),
invoiceid varchar(250),
gameid varchar(250),
groupid varchar(250),
subjectid varchar(250),
bookid varchar(250),
issueid varchar(250),
daid varchar(250),
deptid varchar(250),
desigid varchar(250),
pbid varchar(250),
salaryid varchar(250),
userid varchar(250))

select * from Indexx 

--Institute Tables

create table Institute
(InsID varchar(250),
period varchar(250),
InsName varchar(250),
Address1 varchar(250),
Address2 varchar(250),
City varchar(250),
State varchar(250),
Pin varchar(250),
Country varchar(250),
Telephone varchar(250),
Fax varchar(250),
Email varchar(250),
Url1 varchar(250),
Url2 varchar(250),
Category varchar(250),
AccountingManagement varchar(250),
FinancialPeriod varchar(250),
FinancialMonth varchar(250),
FinancialYear integer,
StartDate varchar(250),
StartingMonth varchar(250))

select * from Institute

create table FinancialYear
(InsID varchar(250),
InsName varchar(250),
Period varchar(250),
FiscalNo integer,
Indexx integer,
PeriodValue varchar(250))

select * from FinancialYear

create table Course
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year integer,
CourseName  Varchar(250),
CourseCode Varchar(250),
Duration Varchar(250),
CourseFees float)

select * from Course

create table CourseTermFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year Varchar(250),
Course varchar(250),
Terms varchar(250),
Fees float,
ForMonth integer)

select * from CourseTermFees

create table Features
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
Features varchar(250))

select * from Features

create table Achievements
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
Achievements varchar(250))

select * from Achievements

create Table Accounts
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
Type Varchar(250),
AccountID varchar(250),
AccountName varchar(250),
AccountBalance float)

select * from Accounts

create table AccountingPeriod
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
FinancialPeriod varchar(250))

select * from AccountingPeriod 

create table DefaultInstitute
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
alwayspurchase Varchar(250),
invoicemessage Varchar(250),
ordermessage Varchar(250),
gameexpense Varchar(250),
customfield1 Varchar(250),
customfield2 Varchar(250),
customfield3 Varchar(250),
customfield4 Varchar(250),
customfield5 Varchar(250),
checkcustomfield1 Varchar(250),
checkcustomfield2 Varchar(250),
checkcustomfield3 Varchar(250),
checkcustomfield4 Varchar(250),
checkcustomfield5 Varchar(250),
costmethod Varchar(250),
stockglsalesacc Varchar(250),
stockglinvacc Varchar(250),
stockglcostacc Varchar(250),
stockcostingacc Varchar(250),
masterglsalesacc Varchar(250),
masterglinvacc Varchar(250),
masterglcostacc Varchar(250),
mastercostingacc Varchar(250),
nonstockglsalesacc Varchar(250),
nonstockglinvacc Varchar(250),
nonstockglcostacc Varchar(250),
nonstockcostingacc Varchar(250),
descriptionglsalesacc Varchar(250),
descriptionglinvacc Varchar(250),
descriptionglcostacc Varchar(250),
descriptioncostingacc Varchar(250),
serviceglsalesacc Varchar(250),
serviceglinvacc Varchar(250),
serviceglcostacc Varchar(250),
servicecostingacc Varchar(250),
laborglsalesacc Varchar(250),
laborglinvacc Varchar(250),
laborglcostacc Varchar(250),
laborcostingacc Varchar(250),
assemblyglsalesacc Varchar(250),
assemblyglinvacc Varchar(250),
assemblyglcostacc Varchar(250),
assemblycostingacc Varchar(250),
activitylsalesacc Varchar(250),
activityglinvacc Varchar(250),
activityglcostacc Varchar(250),
activitycostingacc Varchar(250),
chargeglsalesacc Varchar(250),
chargeglinvacc Varchar(250),
chargeglcostacc Varchar(250),
chargecostingacc Varchar(250),
glfreightacc Varchar(250),
autoid Varchar(250),
feesmonth integer,
applydiscount Varchar(250),
monthlyfeesacc Varchar(250),
yearlyfeesacc Varchar(250),
libraryfeesacc Varchar(250),
latefeesacc Varchar(250),
otherfeesacc Varchar(250),
examfeesacc Varchar(250),
discountfeesacc Varchar(250),
bankdepositacc Varchar(250),
purchaseorderacc Varchar(250),
salesinvoiceacc Varchar(250))

select * from DefaultInstitute

create table DefaultLibrary
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
autoid Varchar(250),
chargesaccount Varchar(250))

select * from DefaultLibrary 

create table DefaultPayroll
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
autoid Varchar(250),
salaryaccount Varchar(250),
basicincr float)

select * from DefaultPayroll  

create table Employee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
picture image,
namefirst Varchar(250),
namemiddle Varchar(250),
namelast Varchar(250),
name Varchar(250),
houseno Varchar(250),
address Varchar(250),
city Varchar(250),
district Varchar(250),
state Varchar(250),
pin Varchar(250),
country Varchar(250),
phone Varchar(250),
fax Varchar(250),
dob Varchar(250),
email Varchar(250),
category Varchar(250),
department Varchar(250),
designation Varchar(250),
married Varchar(250),
sex Varchar(250),
handicapped Varchar(250),
presentposition Varchar(250),
retirementdate Varchar(250),
fulladdress Varchar(250),
payinfo Varchar(250),
payscale Varchar(250),
grade float,
basic float,
joiningdate Varchar(250),
phd varchar(250),
qualifiedtest varchar(250),
attachedcopy varchar(250),
incremented varchar(250))

select * from Employee

create table EmployeeLanguage
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
langname Varchar(250),
canread Varchar(250),
canwrite Varchar(250),
canspeak Varchar(250),
canconversation Varchar(250))

select * from EmployeeLanguage 

create table EmployeeAcademic
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
degree Varchar(250),
passingyear integer,
subjects Varchar(250),
percentagemarks float,
classdivision Varchar(250))

select * from EmployeeAcademic

create table EmployeeTeachingExp
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
totaltexpyear integer,
totaltexpmonth integer,
institution Varchar(250),
designation Varchar(250),
totalyears integer,
ug Varchar(250),
degree Varchar(250),
pg Varchar(250))

select * from EmployeeTeachingExp 

create table EmployeeResearchExp
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
totalrexpyear integer,
totalrexpmonth integer,
research Varchar(250),
institution Varchar(250),
topic Varchar(250),
researchperiod Varchar(250))

select * from EmployeeResearchExp 

create table EmployeeProficiency
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
msword Varchar(250),
msexcel Varchar(250),
mspowerpoint Varchar(250),
internet Varchar(250),
knowemail Varchar(250),
cmserp Varchar(250))

select * from EmployeeProficiency 

create table EmployeeProgrammingLang
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
lang Varchar(250))

select * from EmployeeProgrammingLang 

create table EmployeeActivity
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
publishedbooks varchar(250),
publishedpaper varchar(250),
publishedarticles varchar(250),
seminar Varchar(250),
adminisexp Varchar(250),
otheractivities Varchar(250),
poriodnotice Varchar(250),
referee1 Varchar(250),
referee2 Varchar(250),
referee3 Varchar(250),
otherinfo Varchar(250))

select * from EmployeeActivity 

create table HiredEmployee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
picture image,
namefirst Varchar(250),
namemiddle Varchar(250),
namelast Varchar(250),
name Varchar(250),
houseno Varchar(250),
address Varchar(250),
city Varchar(250),
district Varchar(250),
state Varchar(250),
pin Varchar(250),
country Varchar(250),
phone Varchar(250),
fax Varchar(250),
dob Varchar(250),
email Varchar(250),
category Varchar(250),
department Varchar(250),
designation Varchar(250),
married Varchar(250),
sex Varchar(250),
handicapped Varchar(250),
presentposition Varchar(250),
retirementdate Varchar(250),
fulladdress Varchar(250),
payinfo Varchar(250),
pay float,
joiningdate Varchar(250))

select * from HiredEmployee 

create table RetiredEmployee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
picture image,
namefirst Varchar(250),
namemiddle Varchar(250),
namelast Varchar(250),
name Varchar(250),
houseno Varchar(250),
address Varchar(250),
city Varchar(250),
district Varchar(250),
state Varchar(250),
pin Varchar(250),
country Varchar(250),
phone Varchar(250),
fax Varchar(250),
dob Varchar(250),
email Varchar(250),
category Varchar(250),
department Varchar(250),
designation Varchar(250),
married Varchar(250),
sex Varchar(250),
handicapped Varchar(250),
presentposition Varchar(250),
retirementdate Varchar(250),
fulladdress Varchar(250),
payinfo Varchar(250),
payscale Varchar(250),
grade float,
basic float,
joiningdate Varchar(250),
phd varchar(250),
qualifiedtest varchar(250),
attachedcopy varchar(250),
incremented varchar(250))

select * from RetiredEmployee

create table RetiredEmployeeLanguage
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
langname Varchar(250),
canread Varchar(250),
canwrite Varchar(250),
canspeak Varchar(250),
canconversation Varchar(250))

select * from RetiredEmployeeLanguage 

create table RetiredEmployeeAcademic
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
degree Varchar(250),
passingyear integer,
subjects Varchar(250),
percentagemarks float,
classdivision Varchar(250))

select * from RetiredEmployeeAcademic

create table RetiredEmployeeTeachingExp
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
totaltexpyear integer,
totaltexpmonth integer,
institution Varchar(250),
designation Varchar(250),
totalyears integer,
ug Varchar(250),
degree Varchar(250),
pg Varchar(250))

select * from RetiredEmployeeTeachingExp 

create table RetiredEmployeeResearchExp
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
totalrexpyear integer,
totalrexpmonth integer,
research Varchar(250),
institution Varchar(250),
topic Varchar(250),
researchperiod Varchar(250))

select * from RetiredEmployeeResearchExp 

create table RetiredEmployeeProficiency
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
msword Varchar(250),
msexcel Varchar(250),
mspowerpoint Varchar(250),
internet Varchar(250),
knowemail Varchar(250),
cmserp Varchar(250))

select * from RetiredEmployeeProficiency 

create table RetiredEmployeeProgrammingLang
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
lang Varchar(250))

select * from RetiredEmployeeProgrammingLang 

create table RetiredEmployeeActivity
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid varchar(250),
publishedbooks varchar(250),
publishedpaper varchar(250),
publishedarticles varchar(250),
seminar Varchar(250),
adminisexp Varchar(250),
otheractivities Varchar(250),
poriodnotice Varchar(250),
referee1 Varchar(250),
referee2 Varchar(250),
referee3 Varchar(250),
otherinfo Varchar(250))

select * from RetiredEmployeeActivity 

create table RetiredPF
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
joiningdate Varchar(250),
openingbalance float,
outstandingadvance float)

select * from RetiredPF 

create table EmployeeAttendance
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
empid Varchar(250),
name Varchar(250),
day1name Varchar(250),
day1atten Varchar(250),
day2name Varchar(250),
day2atten Varchar(250),
day3name Varchar(250),
day3atten Varchar(250),
day4name Varchar(250),
day4atten Varchar(250),
day5name Varchar(250),
day5atten Varchar(250),
day6name Varchar(250),
day6atten Varchar(250),
day7name Varchar(250),
day7atten Varchar(250))

select * from EmployeeAttendance

create table StudentAttendance
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
stuid Varchar(250),
name Varchar(250),
day1name Varchar(250),
day1atten Varchar(250),
day2name Varchar(250),
day2atten Varchar(250),
day3name Varchar(250),
day3atten Varchar(250),
day4name Varchar(250),
day4atten Varchar(250),
day5name Varchar(250),
day5atten Varchar(250),
day6name Varchar(250),
day6atten Varchar(250),
day7name Varchar(250),
day7atten Varchar(250))

select * from StudentAttendance

create table Notice
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
noticeid Varchar(250),
noticefor Varchar(250),
noticedate Varchar(250),
subject Varchar(250),
notice Varchar(250))

select * from Notice 

create table IDCard
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
idserial Varchar(250),
idfor Varchar(250),
date Varchar(250),
regno Varchar(250),
name Varchar(250),
dob Varchar(250),
sex Varchar(250),
coursedesig Varchar(250),
address Varchar(250))

select * from IDCard 

create table StudentAdmision
(InsID Varchar(250),
InsName Varchar(250),
Period Varchar(250),
SystemDate varchar(250),
serial Varchar(250),
year integer,
preadmitted Varchar(250),
preadmissionid Varchar(250),
course Varchar(250),
approved Varchar(250),
class Varchar(250),
classint integer,
classstring Varchar(250),
picture image,
fname Varchar(250),
mname Varchar(250),
lname Varchar(250),
name  Varchar(250),
dob Varchar(250),
sex Varchar(250),
fgname Varchar(250),
mothername Varchar(250),
coursefee float,
annualincome float,
prehouseno Varchar(250),
preaddress Varchar(250),
precity Varchar(250),
prepost Varchar(250),
predist Varchar(250),
prestate Varchar(250),
prepin Varchar(250),
precountry Varchar(250),
perhouseno Varchar(250),
peraddress Varchar(250),
percity Varchar(250),
perpost Varchar(250),
perdist Varchar(250),
perstate Varchar(250),
perpin Varchar(250),
percountry Varchar(250),
profcourse Varchar(250),
profcourseduration Varchar(250),
profcourseyear integer,
competitiveexam Varchar(250),
institute Varchar(250),
recognized Varchar(250),
instituteaddress Varchar(250),
institutephone Varchar(250),
institutefax Varchar(250),
instituteuniv Varchar(250),
payeename Varchar(250),
bankname Varchar(250),
bankbrach Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
accountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electronictransfer Varchar(250),
cardholdername Varchar(250),
cardaddress Varchar(250),
cardcity Varchar(250),
cardstate Varchar(250),
cardpin Varchar(250),
cardcountry Varchar(250),
cardtype Varchar(250),
payvia Varchar(250),
cardno Varchar(250),
expmm integer,
expyy integer,
email Varchar(250),
homephone Varchar(250),
workphone Varchar(250),
fax Varchar(250))

select * from StudentAdmision 

create table StudentAdmisionExam
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
stuid Varchar(250),
fname Varchar(250),
mname Varchar(250),
name  Varchar(250),
lname Varchar(250),
exam Varchar(250),
board Varchar(250),
subject Varchar(250),
passingyear integer,
marks float,
division Varchar(250))

select * from StudentAdmisionExam 

create table StudentPreAdmission
(InsID Varchar(250),
InsName Varchar(250),
Period Varchar(250),
SystemDate varchar(250),
serial Varchar(250),
year integer,
fname Varchar(250),
mname Varchar(250),
lname Varchar(250),
name  Varchar(250),
dob Varchar(250),
sex Varchar(250),
fgname Varchar(250),
mothername Varchar(250),
picture image,
houseno Varchar(250),
address Varchar(250),
city Varchar(250),
post Varchar(250),
dist Varchar(250),
state Varchar(250),
pin Varchar(250),
country Varchar(250),
email Varchar(250),
homephone Varchar(250),
workphone Varchar(250),
fax Varchar(250),
class Varchar(250),
classint integer,
classstring Varchar(250),
course Varchar(250),
testfee float,
othertestfee float,
coursefee float,
annualincome float,
payeename Varchar(250),
bankname Varchar(250),
bankbrach Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
accountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electronictransfer Varchar(250),
cardholdername Varchar(250),
cardaddress Varchar(250),
cardcity Varchar(250),
cardstate Varchar(250),
cardpin Varchar(250),
cardcountry Varchar(250),
cardtype Varchar(250),
payvia Varchar(250),
cardno Varchar(250),
expmm integer,
expyy integer)

select * from StudentPreAdmission 

create table StudentRegistration
(InsID Varchar(250),
InsName Varchar(250),
Period Varchar(250),
SystemDate varchar(250),
serial Varchar(250),
year integer,
preadmitted Varchar(250),
preadmissionid Varchar(250),
course Varchar(250),
approved Varchar(250),
class Varchar(250),
classint integer,
classstring Varchar(250),
picture image,
fname Varchar(250),
mname Varchar(250),
lname Varchar(250),
name  Varchar(250),
fgname Varchar(250),
mothername Varchar(250),
dob Varchar(250),
sex Varchar(250),
coursefee float,
annualincome float,
prehouseno Varchar(250),
preaddress Varchar(250),
precity Varchar(250),
prepost Varchar(250),
predist Varchar(250),
prestate Varchar(250),
prepin Varchar(250),
precountry Varchar(250),
perhouseno Varchar(250),
peraddress Varchar(250),
percity Varchar(250),
perpost Varchar(250),
perdist Varchar(250),
perstate Varchar(250),
perpin Varchar(250),
percountry Varchar(250),
profcourse Varchar(250),
profcourseduration Varchar(250),
profcourseyear integer,
institute Varchar(250),
recognized Varchar(250),
instituteaddress Varchar(250),
institutephone Varchar(250),
institutefax Varchar(250),
instituteuniv Varchar(250),
payeename Varchar(250),
bankname Varchar(250),
bankbrach Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
accountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electronictransfer Varchar(250),
cardholdername Varchar(250),
cardaddress Varchar(250),
cardcity Varchar(250),
cardstate Varchar(250),
cardpin Varchar(250),
cardcountry Varchar(250),
cardtype Varchar(250),
payvia Varchar(250),
cardno Varchar(250),
expmm integer,
expyy integer,
email Varchar(250),
homephone Varchar(250),
workphone Varchar(250),
fax Varchar(250),
stuid Varchar(250),
roll Varchar(250),
time Varchar(250),
tuition Varchar(250),
emergencyname Varchar(250),
emergencyhomeph Varchar(250),
emergencyworkph Varchar(250),
emergencyfax Varchar(250),
emergencyrelation Varchar(250),
emergencyaddress Varchar(250))

select * from StudentRegistration

create table MonthlyFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
monthlyrs float,
othersrs float,
laters float,
libraryrs float,
discountcharge float,
discount float,
totalamt float,
paidamt float,
payvia varchar(250),
remainingamt float,
paid Varchar(250))

select * from MonthlyFees

create table OtherFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
payvia Varchar(250),
reason Varchar(250),
otherrs float,
discountcharge float,
discount float,
totalamt float,
pay float,
remaining float,
paid Varchar(250))

select * from OtherFees

create table LateFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
payvia Varchar(250),
reason Varchar(250),
laters float,
discountcharge float,
discount float,
totalamt float,
pay float,
remaining float,
paid Varchar(250))

select * from LateFees

create table ExamFee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
payvia Varchar(250),
exam varchar(250),
examfee float,
laters float,
libraryrs float,
discountcharge float,
discount float,
totalamt float,
pay float,
remaining float,
paid Varchar(250))

select * from ExamFee

create table libraryFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
payvia Varchar(250),
libraryfee float,
laters float,
discountcharge float,
discount float,
totalamt float,
pay float,
remaining float,
paid Varchar(250))

select * from libraryFees

create table YearlyFees
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
token Varchar(250),
date varchar(250),
month integer,
year integer,
course Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
time Varchar(250),
payvia Varchar(250),
yearlyfee float,
laters float,
otherrs float,
libraryrs float,
discountcharge float,
discount float,
totalamt float,
pay float,
remaining float,
paid Varchar(250))

select * from YearlyFees

create table Discount
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
date varchar(250),
month integer,
year integer,
appliedfor Varchar(250),
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
totalamt float,
discountcharge float,
discount float,
pay float,
payvia varchar(250),
authentication Varchar(250),
remarks Varchar(250),
account varchar(250))

select * from Discount

create table StudentDiscount
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
year Varchar(250),
course Varchar(250),
class Varchar(250),
roll Varchar(250),
stuid Varchar(250),
name Varchar(250),
discount float)

select * from StudentDiscount

create table FinancialLoan
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
course Varchar(250),
picture image,
class Varchar(250),
roll Varchar(250),
name Varchar(250),
regno Varchar(250),
applicantno Varchar(250),
fgname Varchar(250),
dob Varchar(250),
sex Varchar(250),
nationality Varchar(250),
religion Varchar(250),
email Varchar(250),
homeph Varchar(250),
workph Varchar(250),
houseno Varchar(250),
address Varchar(250),
city Varchar(250),
post Varchar(250),
district Varchar(250),
state Varchar(250),
pincode Varchar(250),
country Varchar(250),
attachmentname Varchar(250),
attachmentsize Varchar(250),
attachmentpath Varchar(250),
attachmentnote Varchar(6000))

select * from FinancialLoan

create table IncomeExpenditure
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
transactionid Varchar(250),
descriptions Varchar(250),
type Varchar(250),
amount float,
class Varchar(250),
roll Varchar(250),
regno Varchar(250),
name Varchar(250),
month integer,
year integer,
account Varchar(250))

select * from IncomeExpenditure

create table BankDeposit
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
depositid Varchar(250),
date Varchar(250),
amount float,
payvia Varchar(250),
checkno Varchar(250),
account Varchar(250),
payeename Varchar(250),
bankname Varchar(250),
branchname Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
bankaccountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electransfer Varchar(250))

select * from BankDeposit

create table Examination
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
examcode Varchar(250),
course Varchar(250),
subject Varchar(250),
examdate Varchar(250),
branch Varchar(250),
examcenter Varchar(250),
examfor Varchar(250),
examinstitute Varchar(250),
examtime Varchar(250),
roomno Varchar(250))

select * from Examination 

create table ExamStudents
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
examcode Varchar(250),
stuid Varchar(250),
name Varchar(250),
course Varchar(250))

select * from ExamStudents 

create table ExamGuard
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
examcode Varchar(250),
guard Varchar(250))

select * from ExamGuard 

create table OnlineExamQsn
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate Varchar(250),
examid Varchar(250),
examdate Varchar(250),
examtime Varchar(250),
examduration integer,
qsn Varchar(250),
ans1 Varchar(250),
ans2 Varchar(250),
ans3 Varchar(250),
ans4 Varchar(250),
rightans Varchar(250))

select * from OnlineExamQsn 

create table OnlineExam
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate Varchar(250),
examid Varchar(250),
examdate Varchar(250),
examtime Varchar(250),
examduration integer,
stuid Varchar(250),
name Varchar(250),
course Varchar(250),
class Varchar(250),
roll Varchar(250),
totalqsn integer,
totalqsnanswered integer,
rightanswered integer)

select * from OnlineExam

create table Subjects
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
course Varchar(250),
coursecode Varchar(250),
haspractical Varchar(250),
gensubject Varchar(250),
gensubjectduration Varchar(250),
gensubjectcode Varchar(250),
gensubjectyear integer,
gensubjectsemestar Varchar(250),
pracsubject Varchar(250),
pracsubjectduration Varchar(250),
pracsubjectcode Varchar(250),
pracsubjectyear integer,
pracsubjectsemestar Varchar(250))

select * from Subjects 

create table Syllabus
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
course Varchar(250),
coursecode Varchar(250),
subject Varchar(250),
subjectcode Varchar(250),
forstudent Varchar(250),
chapter Varchar(250),
chapterdetails Varchar(250),
totalmarks integer,
marksobtained integer,
totalclass integer,
class integer)

select * from Syllabus

create table Assignment
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
assignmentid Varchar(250),
date Varchar(250),
course Varchar(250),
subject Varchar(250),
assignment Varchar(250))

select * from Assignment 

create table Marksheet
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
markid Varchar(250),
stuid Varchar(250),
name Varchar(250),
course Varchar(250),
class Varchar(250),
roll Varchar(250),
examinfo Varchar(250),
examdate Varchar(250),
examtime Varchar(250),
subject Varchar(250),
fullmarks float,
scored float)

select * from Marksheet

create table ProgressReport
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
progressid Varchar(250),
stuid Varchar(250),
attendance Varchar(250),
preparation Varchar(250),
homework Varchar(250),
takerisk Varchar(250),
goals Varchar(250),
plans Varchar(250),
respect Varchar(250),
cooperation Varchar(250),
interest Varchar(250),
motivation Varchar(250),
outcomes Varchar(250),
quality Varchar(250),
keyterms Varchar(250),
newconcept Varchar(250))

select * from ProgressReport 

create table StudentControl
(InsID Varchar(250),
InsName Varchar(250),
Period Varchar(250),
SystemDate varchar(250),
controlid Varchar(250),
regno Varchar(250),
name Varchar(250),
course Varchar(250),
examination Varchar(250),
scored float,
passfail Varchar(250),
credits float,
reference Varchar(250),
remarks Varchar(2000),
alsoupdate Varchar(250),
newcouse Varchar(250),
newclassint integer,
newclassstring Varchar(250),
newclass Varchar(250),
newroll Varchar(250),
newtime Varchar(250),
newtuition Varchar(250))

select * from StudentControl 

create table Alumni
(InsID Varchar(250),
InsName Varchar(250),
Period Varchar(250),
SystemDate varchar(250),
serial Varchar(250),
alumniyear integer,
year integer,
preadmitted Varchar(250),
preadmissionid Varchar(250),
course Varchar(250),
approved Varchar(250),
class Varchar(250),
classint integer,
classstring Varchar(250),
picture image,
fname Varchar(250),
mname Varchar(250),
lname Varchar(250),
name  Varchar(250),
fgname Varchar(250),
mothername Varchar(250),
dob Varchar(250),
sex Varchar(250),
coursefee float,
annualincome float,
prehouseno Varchar(250),
preaddress Varchar(250),
precity Varchar(250),
prepost Varchar(250),
predist Varchar(250),
prestate Varchar(250),
prepin Varchar(250),
precountry Varchar(250),
perhouseno Varchar(250),
peraddress Varchar(250),
percity Varchar(250),
perpost Varchar(250),
perdist Varchar(250),
perstate Varchar(250),
perpin Varchar(250),
percountry Varchar(250),
profcourse Varchar(250),
profcourseduration Varchar(250),
profcourseyear integer,
institute Varchar(250),
recognized Varchar(250),
instituteaddress Varchar(250),
institutephone Varchar(250),
institutefax Varchar(250),
instituteuniv Varchar(250),
payeename Varchar(250),
bankname Varchar(250),
bankbrach Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
accountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electronictransfer Varchar(250),
cardholdername Varchar(250),
cardaddress Varchar(250),
cardcity Varchar(250),
cardstate Varchar(250),
cardpin Varchar(250),
cardcountry Varchar(250),
cardtype Varchar(250),
payvia Varchar(250),
cardno Varchar(250),
expmm integer,
expyy integer,
email Varchar(250),
homephone Varchar(250),
workphone Varchar(250),
fax Varchar(250),
stuid Varchar(250),
roll Varchar(250),
time Varchar(250),
tuition Varchar(250),
emergencyname Varchar(250),
emergencyhomeph Varchar(250),
emergencyworkph Varchar(250),
emergencyfax Varchar(250),
emergencyrelation Varchar(250),
emergencyaddress Varchar(250))

select * from Alumni 

create table StudentCertificate
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
certificateid Varchar(250),
regno Varchar(250),
name Varchar(250),
certificatefor Varchar(250),
issuedate Varchar(250),
verified Varchar(250),
verifiedby Varchar(250),
remarks Varchar(5000))

select * from StudentCertificate 

create table EmployeeCertificate
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
certificateid Varchar(250),
regno Varchar(250),
name Varchar(250),
certificatefor Varchar(250),
issuedate Varchar(250),
verified Varchar(250),
verifiedby Varchar(250),
schooltype1 Varchar(5000),
schooltype2 Varchar(5000),
schooltype3 Varchar(5000),
schooltype4 Varchar(5000),
schooltype5 Varchar(5000),
schooltype6 Varchar(5000),
type1 Varchar(5000),
type2 Varchar(5000),
type3 Varchar(5000),
workingfor Varchar(250))

select * from EmployeeCertificate

create table InventoryHistory
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
itemid varchar(250),
itemname varchar(250),
itemclass varchar(250),
purpose varchar(250),
price float,
id varchar(250),
date varchar(250),
qunatity float,
unit varchar(250))

select * from InventoryHistory 

create table Inventory
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
itemid varchar(250),
itemnote varchar(250),
itemname varchar(250),
itemclass varchar(250),
descshort varchar(250),
itemsize varchar(250),
itemshape varchar(250),
itemused varchar(250),
descripbrief varchar(250),
levelprice float,
onhandqnty float,
onhandqntyunit varchar(250),
lastsoldprice float,
costmethod varchar(250),
minstockqnty float,
minstockqntyunit varchar(250),
itemtaxtype varchar(250),
itemtype varchar(250),
stocking varchar(250),
weight float,
weightunit varchar(250),
vendorname varchar(250),
glsalesaccountid varchar(250),
glinventoryaccountid varchar(250),
glcostsaccountid varchar(250),
costingaccountid varchar(250),
customfield1 varchar(250),
customfield2 varchar(250),
customfield3 varchar(250),
customfield4 varchar(250),
customfield5 varchar(250),
inactive varchar(250),
commission varchar(250),
UnitPrice float)

select * from Inventory

create table InventoryItemPriceLevel
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
itemid Varchar(250),
itemname Varchar(250),
itemdesc Varchar(250),
levelprice1 float,
levelprice2 float,
levelprice3 float,
levelprice4 float,
levelprice5 float,
levelprice6 float,
levelprice7 float,
levelprice8 float,
levelprice9 float,
levelprice10 float,
defaultlevel Varchar(250))

select * from InventoryItemPriceLevel

create table Purchase
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
purchaseid varchar(250),
purchasedate varchar(250),
vendorname varchar(250),
vendoraddress varchar(250),
vendorphone varchar(250),
vendoremail varchar(250),
shipto varchar(250),
shipaddress varchar(250),
shipphone varchar(250),
shipemail varchar(250),
expenseaccount varchar(250),
taxrate float,
itemid varchar(250),
itemname varchar(250),
itemclass varchar(250),
itemqnty float,
itemunit varchar(250),
itemprice float,
itemtax float,
itemtotal float,
totalprice float,
totaltax float,
totalamount float,
purchasenote varchar(250),
duedate  varchar(250),
paid varchar(250))

select * from Purchase

create table SalesInvoice
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
invoiceno varchar(250),
invoicedate varchar(250),
customername varchar(250),
customeraddress varchar(250),
customerphone varchar(250),
customeremail varchar(250),
glsalesaccount varchar(250),
taxrate float,
itemid varchar(250),
itemname varchar(250),
itemclass varchar(250),
qnty float,
unit varchar(250),
itemprice float,
itemtax float,
itemamount float,
totalprice float,
totaltax float,
totalamount float,
invoicenote varchar(250),
duedate varchar(250),
paid varchar(250))

select * from SalesInvoice 

create table Game
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
gameid Varchar(250),
category Varchar(250),
gamefor Varchar(250),
department Varchar(250),
date Varchar(250),
time Varchar(250),
gamename Varchar(250),
gameplace Varchar(250),
expense float,
account Varchar(250))

select * from Game 

--Library Tables

create table GroupBooks
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
groupid Varchar(250),
groupname Varchar(250),
groupdetails Varchar(5000))

select * from GroupBooks

create table SubjectBooks
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
subjectid Varchar(250),
subjectname Varchar(250),
subjectdetails Varchar(5000))

select * from SubjectBooks

create table Books
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
bookid Varchar(250),
bookname Varchar(250),
groupname Varchar(250),
subject Varchar(250),
publisher Varchar(250),
author Varchar(250),
edition Varchar(250),
copies integer,
pages integer,
price float,
particulars Varchar(5000))

select * from Books

create table BookCharges
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
course Varchar(250),
referencebooks Varchar(250),
finerate float,
reserveperiod integer,
maxbooks integer,
booksreturndays integer,
maxjournal integer,
journalreturndays integer,
maxcompbook integer,
compbookreturndays integer,
lockerperiod integer,
lockerfees float,
losingcardcharge float,
lockerfine float,
losingjournalcharge float,
idcardcharge float)

select * from BookCharges

create table Issue
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
issedto Varchar(250),
issuedtoname Varchar(250),
issuedtoid Varchar(250),
contactno Varchar(250),
email Varchar(250),
issueid Varchar(250),
issuedate Varchar(250),
duedate Varchar(250),
issedby Varchar(250),
returned Varchar(250),)

select * from Issue

create table IssueBooks
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
issueid Varchar(250),
issuedtoid Varchar(250),
issuedate Varchar(250),
bookname Varchar(250),
bookid Varchar(250),
author Varchar(250),
edition Varchar(250))

select * from IssueBooks

create table ReturnBooks
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
issueid Varchar(250),
date Varchar(250),
issuedate Varchar(250),
returndate Varchar(250),
applylatecharge Varchar(250),
regno Varchar(250),
name Varchar(250))

select * from ReturnBooks

create table LibraryCharges
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
SystemDate varchar(250),
date Varchar(250),
issueid Varchar(250),
issuedate Varchar(250),
regno Varchar(250),
name Varchar(250),
latedays integer,
latefees float,
losingbooks float,
losingjournal float,
losingcompbooks float,
newidcard float,
losingidcard float,
lockerfees float,
lockerfine float,
otherfees float,
reason Varchar(250),
totalcharges float,
payeename Varchar(250),
bankname Varchar(250),
bankbranch Varchar(250),
branchaddress Varchar(250),
branchcode Varchar(250),
bankaccountno Varchar(250),
accounttype Varchar(250),
micrcode Varchar(250),
electransfer Varchar(250),
payvia Varchar(250),
account Varchar(250))

select * from LibraryCharges

--Payroll Tables

create table Department
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
deptid Varchar(250),
deptname Varchar(250))

select * from Department 

create table Designation
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
desigid Varchar(250),
designame Varchar(250))

select * from Designation 

create table PayScale
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
pbname Varchar(250),
pblower float,
pbupper float,
pbgrade float,
pbbasic float,
payscale Varchar(250))

select * from PayScale 

create table DaHra
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
ID integer,
effectmonth integer,
effectyear integer,
darate float,
hrarate float,
maximum float,
medical float)

select * from DaHra 

create table ProfessionalTax
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
gross float,
taxrate float)

select * from ProfessionalTax 

create table PayslipHeaders
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
allowancedesc1 Varchar(250),
allowanceshortdesc1 Varchar(250),
allowancedesc2 Varchar(250),
allowanceshortdesc2 Varchar(250),
allowancedesc3 Varchar(250),
allowanceshortdesc3 Varchar(250),
allowancedesc4 Varchar(250),
allowanceshortdesc4 Varchar(250),
deductiondesc1 Varchar(250),
deductionshortdesc1 Varchar(250),
deductiondesc2 Varchar(250),
deductionshortdesc2 Varchar(250),
deductiondesc3 Varchar(250),
deductionshortdesc3 Varchar(250),
signatorydesc1 Varchar(250),
signatoryshortdesc1 Varchar(250),
signatorydesc2 Varchar(250),
signatoryshortdesc2 Varchar(250),
signatorydesc3 Varchar(250),
signatoryshortdesc3 Varchar(250))

select * from PayslipHeaders 

create table PFRate
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year integer,
rate float,
amount float)

select * from PFRate 

create table PFRateIndividual
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
year integer,
regno Varchar(250),
name Varchar(250),
rate float,
amount float)

select * from PFRateIndividual 

create table AdjustmentDeductions
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
year integer,
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
thismonth integer,
lastmonth integer,
basicadjust float,
daadjust float,
hraadjust float,
otheradjust float,
ccsadjust float,
incometaxadjust float,
salaryadjust float,
conveyancealw float,
handicappedalw float,
washingalw float,
pfdeduction float,
conveyancealwrs float,
handicappedalwrs float,
washingalwrs float,
pfdeductionrs float,
specialpay float,
gslideduction float,
houserent float,
pfadvancerecovery float,
ccsloan float,
otherbankloan float,
festivaladvance float,
ccspo1loan float,
ccspo2loan float,
bankloan float,
ppfloan float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from AdjustmentDeductions 

create table WorkingHourly
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
empid Varchar(250),
name Varchar(250),
date Varchar(250),
starttime Varchar(250),
endtime Varchar(250),
totalminutes integer)

select * from WorkingHourly 

create table WorkingDaily
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
empid Varchar(250),
name Varchar(250),
date Varchar(250),
presentabsent Varchar(250))

select * from WorkingDaily 

create table Salary
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
year integer,
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
thismonth integer,
lastmonth integer,
basicadjust float,
daadjust float,
hraadjust float,
otheradjust float,
ccsadjust float,
incometaxadjust float,
salaryadjust float,
conveyancealw float,
handicappedalw float,
washingalw float,
pfdeduction float,
conveyancealwrs float,
handicappedalwrs float,
washingalwrs float,
pfdeductionrs float,
specialpay float,
gslideduction float,
houserent float,
pfadvancerecovery float,
ccsloan float,
otherbankloan float,
festivaladvance float,
ccspo1loan float,
ccspo2loan float,
bankloan float,
ppfloan float,
GetDA float,
GetArrier float,
GetHRA float,
DADeductThis float,
DADeductLast float,
DADeductionTotal float,
HRADeductThis float,
HRADeductLast float,
HRADeductTotal float,
DeductedMedical float,
ProfessionTax float,
TotalDeduction float,
TotalGain float,
NewBasic float,
EmployerPFDeduct float,
NetPay float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from Salary 

create table PayEmployee
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
payslipno Varchar(250),
salarymonth Varchar(250),
salaryyear integer,
salarydate Varchar(250),
regno Varchar(250),
name Varchar(250),
designation Varchar(250),
payinfo Varchar(250),
getda float,
getarrier float,
gethra float,
tax float,
deduct float,
gain float,
newbasic float,
netpay float,
stopincrement Varchar(250),
paywithheld Varchar(250))

select * from PayEmployee 

create table PF
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
regno Varchar(250),
designation Varchar(250),
name Varchar(250),
joiningdate Varchar(250),
openingbalance float,
outstandingadvance float)

select * from PF 

create table PFAdvanceWithdrawal
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
month Varchar(250),
regno Varchar(250),
name Varchar(250),
openingbalance float,
options Varchar(250),
amount float,
particulars Varchar(250))

select * from PFAdvanceWithdrawal 

create table CloseMembership
(InsID varchar(250),
InsName varchar(250),
Period Varchar(250),
regno Varchar(250),
name Varchar(250),
closingbal float,
outstanding float,
closingdate Varchar(250))

select * from CloseMembership 