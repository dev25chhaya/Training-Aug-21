import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentAddmissionComponent } from './student-addmission.component';

describe('StudentAddmissionComponent', () => {
  let component: StudentAddmissionComponent;
  let fixture: ComponentFixture<StudentAddmissionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StudentAddmissionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StudentAddmissionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
