import { greet } from "./greet"

describe('greet', () => {
    it('should contains name in return messages', () => {
        expect(greet('Angular')).toContain('Angular')
    })
})