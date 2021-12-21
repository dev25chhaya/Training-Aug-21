import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CssFilesComponent } from './css-files.component';

describe('CssFilesComponent', () => {
  let component: CssFilesComponent;
  let fixture: ComponentFixture<CssFilesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CssFilesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CssFilesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
