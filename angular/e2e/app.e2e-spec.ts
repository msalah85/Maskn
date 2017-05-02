import { MasknTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: MasknTemplatePage;

  beforeEach(() => {
    page = new MasknTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
