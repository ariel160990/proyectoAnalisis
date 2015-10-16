Feature: ConsultarCaso
	Find a result on database for a case
	As a all registers in the table
	I want show the register to the number specific

@mytag
Scenario: Select a register
	Given a number in a textbox 
	And and verify this field is not empty
	When press the button consultar
	Then the fields are visible and show the information
