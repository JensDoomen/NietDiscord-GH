

describe('My First Test', () => {
    it('Does not do much!', () => {
        expect(true).to.equal(true)
    })
});

describe('send message', ()=> {
    it('sends the message', ()=> {
        cy.visit('http://localhost:8081/')
        cy.get('input').type('Hello, World')
        cy.contains('Send').click();
    })
});