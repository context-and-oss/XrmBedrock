declare namespace Form.account.Quick {
  namespace AccountReferencePanel {
    namespace Tabs {
      interface tab_1 extends XDTForm.SectionCollectionBase {
        get(name: "tab_1_column_1_section_1"): Xrm.Controls.Section;
        get(name: "tab_1_section_2"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "address1_city"): Xrm.Controls.StringControl;
      get(name: "address1_line1"): Xrm.Controls.StringControl;
      get(name: "address1_line2"): Xrm.Controls.StringControl;
      get(name: "address1_postalcode"): Xrm.Controls.StringControl;
      get(name: "emailaddress1"): Xrm.Controls.StringControl;
      get(name: "name"): Xrm.Controls.StringControl;
      get(name: "numberofemployees"): Xrm.Controls.NumberControl;
      get(name: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
      get(name: "primarycontactid"): XDTForm.LookupControl<"contact">;
      get(name: "revenue"): Xrm.Controls.NumberControl;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: string): null;
      get(): Xrm.Controls.Control[];
      get(index: number): Xrm.Controls.Control;
      get(chooser: (item: Xrm.Controls.Control, index: number) => boolean): Xrm.Controls.Control[];
    }


    interface Tabs extends XDTForm.TabCollectionBase {
      get(name: "tab_1"): XDTForm.PageTab<Tabs.tab_1>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface AccountReferencePanel extends XDTForm.QuickViewForm<AccountReferencePanel.Tabs,AccountReferencePanel.Controls> {
    getAttribute(attributeName: "address1_city"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "numberofemployees"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
    getAttribute(attributeName: "revenue"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "address1_city"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line1"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line2"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_postalcode"): Xrm.Controls.StringControl;
    getControl(controlName: "emailaddress1"): Xrm.Controls.StringControl;
    getControl(controlName: "name"): Xrm.Controls.StringControl;
    getControl(controlName: "numberofemployees"): Xrm.Controls.NumberControl;
    getControl(controlName: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "primarycontactid"): XDTForm.LookupControl<"contact">;
    getControl(controlName: "revenue"): Xrm.Controls.NumberControl;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
