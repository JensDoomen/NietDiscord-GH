

describe('My First Test', () => {
    it('Does not do much!', () => {
        expect(true).to.equal(true)
    })
});

describe('send message', ()=> {
    it('sends the message', ()=> {
        cy.visit('http://localhost:8081/')
        cy.contains('Login').click();
        cy.get('input').first().type("Otto@mail.comn");
        cy.get('input').eq(1).type("Test22");

        cy.visit('http://localhost:8081/autherized')
        
        //cy.contains('message').click();
        cy.get('input').type('Hello, World')
        cy.contains('Send').click();
    })
});