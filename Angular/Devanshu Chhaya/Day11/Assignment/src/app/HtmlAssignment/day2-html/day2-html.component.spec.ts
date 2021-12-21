import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Day2HtmlComponent } from './day2-html.component';

describe('Day2HtmlComponent', () => {
  let component: Day2HtmlComponent;
  let fixture: ComponentFixture<Day2HtmlComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Day2HtmlComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Day2HtmlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
