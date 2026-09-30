declare namespace Form.contact.QuickCreate {
  namespace ContactQuickCreate {
    namespace Tabs {
      interface tab_1 extends XDTForm.SectionCollectionBase {
        get(name: "tab_1_column_1_section_1"): Xrm.Controls.Section;
        get(name: "tab_1_column_2_section_1"): Xrm.Controls.Section;
        get(name: "tab_1_column_3_section_1"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }

    interface Attributes extends XDTForm.AttributeCollectionBase {
      get(name: "address1_city"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line1"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line2"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
      get(name: "birthdate"): Xrm.Attributes.DateAttribute | null;
      get(name: "description"): Xrm.Attributes.Attribute<string>;
      get(name: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
      get(name: "firstname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
      get(name: "jobtitle"): Xrm.Attributes.Attribute<string>;
      get(name: "lastname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "middlename"): Xrm.Attributes.Attribute<string> | null;
      get(name: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
      get(name: "name"): Xrm.Attributes.Attribute<string> | null;
      get(name: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
      get(name: "parentcustomerid"): XDTForm.LookupAttribute<"account" | "contact">;
      get(name: "spousesname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "telephone1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
      get(name: string): null;
      get(): Xrm.Attributes.Attribute[];
      get(index: number): Xrm.Attributes.Attribute;
      get(chooser: (item: Xrm.Attributes.Attribute, index: number) => boolean): Xrm.Attributes.Attribute[];
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "address1_city"): Xrm.Controls.StringControl;
      get(name: "address1_line1"): Xrm.Controls.StringControl;
      get(name: "address1_line2"): Xrm.Controls.StringControl;
      get(name: "address1_postalcode"): Xrm.Controls.StringControl;
      get(name: "description"): Xrm.Controls.StringControl;
      get(name: "emailaddress1"): Xrm.Controls.StringControl;
      get(name: "firstname"): Xrm.Controls.StringControl;
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
      get(name: "jobtitle"): Xrm.Controls.StringControl;
      get(name: "lastname"): Xrm.Controls.StringControl;
      get(name: "mobilephone"): Xrm.Controls.StringControl;
      get(name: "parentcustomerid"): XDTForm.LookupControl<"account" | "contact">;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: string): null;
      get(): Xrm.Controls.Control[];
      get(index: number): Xrm.Controls.Control;
      get(chooser: (item: Xrm.Controls.Control, index: number) => boolean): Xrm.Controls.Control[];
    }

    interface QuickViewForms extends XDTForm.QuickViewFormCollectionBase {
      get(name: string): null;
      get(): XDTForm.QuickViewFormBase[];
      get(index: number): XDTForm.QuickViewFormBase;
      get(chooser: (item: XDTForm.QuickViewFormBase, index: number) => boolean): XDTForm.QuickViewFormBase[];
    }


    interface Tabs extends XDTForm.TabCollectionBase {
      get(name: "tab_1"): XDTForm.PageTab<Tabs.tab_1>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface ContactQuickCreate extends XDTForm.FormContextBase<ContactQuickCreate.Attributes,ContactQuickCreate.Tabs,ContactQuickCreate.Controls,ContactQuickCreate.QuickViewForms> {
    getAttribute(attributeName: "address1_city"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "birthdate"): Xrm.Attributes.DateAttribute | null;
    getAttribute(attributeName: "description"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
    getAttribute(attributeName: "firstname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
    getAttribute(attributeName: "jobtitle"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "lastname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "middlename"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
    getAttribute(attributeName: "parentcustomerid"): XDTForm.LookupAttribute<"account" | "contact">;
    getAttribute(attributeName: "spousesname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "address1_city"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line1"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line2"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_postalcode"): Xrm.Controls.StringControl;
    getControl(controlName: "description"): Xrm.Controls.StringControl;
    getControl(controlName: "emailaddress1"): Xrm.Controls.StringControl;
    getControl(controlName: "firstname"): Xrm.Controls.StringControl;
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
    getControl(controlName: "jobtitle"): Xrm.Controls.StringControl;
    getControl(controlName: "lastname"): Xrm.Controls.StringControl;
    getControl(controlName: "mobilephone"): Xrm.Controls.StringControl;
    getControl(controlName: "parentcustomerid"): XDTForm.LookupControl<"account" | "contact">;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
