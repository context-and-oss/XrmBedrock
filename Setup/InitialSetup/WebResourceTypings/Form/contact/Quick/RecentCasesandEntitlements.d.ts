declare namespace Form.contact.Quick {
  namespace RecentCasesandEntitlements {
    namespace Tabs {
      interface general extends XDTForm.SectionCollectionBase {
        get(name: "Cases"): Xrm.Controls.Section;
        get(name: "Entitlements"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "header_process_birthdate"): Xrm.Controls.DateControl | null;
      get(name: "header_process_emailaddress1"): Xrm.Controls.StringControl | null;
      get(name: "header_process_familystatuscode"): XDTForm.OptionSetControl<contact_familystatuscode> | null;
      get(name: "header_process_firstname"): Xrm.Controls.StringControl | null;
      get(name: "header_process_industrycode"): XDTForm.OptionSetControl<number> | null;
      get(name: "header_process_lastname"): Xrm.Controls.StringControl | null;
      get(name: "header_process_middlename"): Xrm.Controls.StringControl | null;
      get(name: "header_process_mobilephone"): Xrm.Controls.StringControl | null;
      get(name: "header_process_name"): Xrm.Controls.StringControl | null;
      get(name: "header_process_parentaccountid"): XDTForm.LookupControl<string> | null;
      get(name: "header_process_spousesname"): Xrm.Controls.StringControl | null;
      get(name: "header_process_telephone1"): Xrm.Controls.StringControl | null;
      get(name: "header_process_websiteurl"): Xrm.Controls.StringControl | null;
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

  interface RecentCasesandEntitlements extends XDTForm.QuickViewForm<RecentCasesandEntitlements.Tabs,RecentCasesandEntitlements.Controls> {
    getAttribute(attributeName: "birthdate"): Xrm.Attributes.DateAttribute | null;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
    getAttribute(attributeName: "firstname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
    getAttribute(attributeName: "lastname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "middlename"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
    getAttribute(attributeName: "spousesname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "header_process_birthdate"): Xrm.Controls.DateControl | null;
    getControl(controlName: "header_process_emailaddress1"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_familystatuscode"): XDTForm.OptionSetControl<contact_familystatuscode> | null;
    getControl(controlName: "header_process_firstname"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_industrycode"): XDTForm.OptionSetControl<number> | null;
    getControl(controlName: "header_process_lastname"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_middlename"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_mobilephone"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_name"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_parentaccountid"): XDTForm.LookupControl<string> | null;
    getControl(controlName: "header_process_spousesname"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_telephone1"): Xrm.Controls.StringControl | null;
    getControl(controlName: "header_process_websiteurl"): Xrm.Controls.StringControl | null;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
