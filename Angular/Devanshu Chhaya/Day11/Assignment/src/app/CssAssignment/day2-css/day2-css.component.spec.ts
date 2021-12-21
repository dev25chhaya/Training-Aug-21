import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Day2CSSComponent } from './day2-css.component';

describe('Day2CSSComponent', () => {
  let component: Day2CSSComponent;
  let fixture: ComponentFixture<Day2CSSComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Day2CSSComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Day2CSSComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
