import { countries } from "./countries"

describe('countries', () => {
    it('should return countries code', () => {
        const result = countries()
        expect(result).toContain('EN')
        expect(result).toContain('US')
        expect(result).toContain('UA')
    })
})