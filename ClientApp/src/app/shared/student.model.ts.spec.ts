import { Student } from './student.model.ts';

describe('Student', () => {
  it('should create an instance', () => {
    expect(new Student()).toBeTruthy();
  });
});
