import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmlFilesComponent } from './html-files.component';

describe('HtmlFilesComponent', () => {
  let component: HtmlFilesComponent;
  let fixture: ComponentFixture<HtmlFilesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HtmlFilesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HtmlFilesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
