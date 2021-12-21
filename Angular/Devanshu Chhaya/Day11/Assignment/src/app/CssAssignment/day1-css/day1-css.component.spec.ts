import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Day1CSSComponent } from './day1-css.component';

describe('Day1CSSComponent', () => {
  let component: Day1CSSComponent;
  let fixture: ComponentFixture<Day1CSSComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Day1CSSComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Day1CSSComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
