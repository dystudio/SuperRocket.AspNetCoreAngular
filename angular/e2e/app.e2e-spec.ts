import { AspNetCoreAngularTemplatePage } from './app.po';

describe('AspNetCoreAngular App', function() {
  let page: AspNetCoreAngularTemplatePage;

  beforeEach(() => {
    page = new AspNetCoreAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
