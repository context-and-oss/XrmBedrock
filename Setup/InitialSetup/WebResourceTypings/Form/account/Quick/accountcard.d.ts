declare namespace Form.account.Quick {
  namespace accountcard {
    namespace Tabs {
      interface general extends XDTForm.SectionCollectionBase {
        get(name: "information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "emailaddress1"): Xrm.Controls.StringControl;
      get(name: "name"): Xrm.Controls.StringControl;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: string): null;
      get(): Xrm.Controls.Control[];
      get(index: number): Xrm.Controls.Control;
      get(chooser: (item: Xrm.Controls.Control, index: number) => boolean): Xrm.Controls.Control[];
    }


    interface Tabs extends XDTForm.TabCollectionBase {
      get(name: "general"): XDTForm.PageTab<Tabs.general>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface accountcard extends XDTForm.QuickViewForm<accountcard.Tabs,accountcard.Controls> {
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "emailaddress1"): Xrm.Controls.StringControl;
    getControl(controlName: "name"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
