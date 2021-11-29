describe('Register a user', ()=> {
    it('Registers a user', ()=> {
        cy.visit('http://localhost:8081/');

        cy.contains('Register').click();
        cy.get('input').first().type("Otto Eduard Leopold von Bismarck-Schönhausen");
        cy.get('input').eq(1).type("Otto@mail.com");
        cy.get('input').eq(2).type("Test22");
        cy.contains('Submit').click();
    })
});

describe('Does not register a user', ()=> {
    it('Does not register a user', ()=> {
        cy.visit('http://localhost:8081/');

        cy.contains('Register').click();
        cy.get('input').first().type("Otto Eduard Leopold von Bismarck-Schönhausen");
        cy.get('input').eq(1).type("Otto@mail.com");
        
        cy.contains('Submit').click();
    })
});