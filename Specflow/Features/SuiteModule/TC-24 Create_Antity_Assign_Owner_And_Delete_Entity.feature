Feature: TC-24 Create_Antity_Assign_Owner_And_Delete_Entity

@TC-24
Scenario: 24 Create entity, assign owner and delete entity
	Given Login to the application with 'Right' user
	When Navigate to Entity page
	Then I create a Entity
	Then I refresh the page
	When Navigate to Entity Owners page
	Then I assign owner to the entity
	Then I refresh the page
	When Navigate to Entity page
	Then I delete the Entity
