declare namespace Form.contact.Main {
  namespace Information {
    namespace Tabs {
      interface administration extends XDTForm.SectionCollectionBase {
        get(name: "billing information"): Xrm.Controls.Section;
        get(name: "contact methods"): Xrm.Controls.Section;
        get(name: "internal information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface details extends XDTForm.SectionCollectionBase {
        get(name: "personal information"): Xrm.Controls.Section;
        get(name: "professional information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface general extends XDTForm.SectionCollectionBase {
        get(name: "address"): Xrm.Controls.Section;
        get(name: "description"): Xrm.Controls.Section;
        get(name: "name"): Xrm.Controls.Section;
        get(name: "shipping information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface notesandactivities extends XDTForm.SectionCollectionBase {
        get(name: "activities"): Xrm.Controls.Section;
        get(name: "notes"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }

    interface Attributes extends XDTForm.AttributeCollectionBase {
      get(name: "accountrolecode"): Xrm.Attributes.OptionSetAttribute<contact_accountrolecode>;
      get(name: "address1_addresstypecode"): Xrm.Attributes.OptionSetAttribute<contact_address1_addresstypecode>;
      get(name: "address1_city"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_country"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<contact_address1_freighttermscode>;
      get(name: "address1_line1"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line2"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line3"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_name"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<contact_address1_shippingmethodcode>;
      get(name: "address1_stateorprovince"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_telephone1"): Xrm.Attributes.Attribute<string>;
      get(name: "anniversary"): Xrm.Attributes.DateAttribute;
      get(name: "assistantname"): Xrm.Attributes.Attribute<string>;
      get(name: "assistantphone"): Xrm.Attributes.Attribute<string>;
      get(name: "birthdate"): Xrm.Attributes.DateAttribute | null;
      get(name: "creditlimit"): Xrm.Attributes.NumberAttribute;
      get(name: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
      get(name: "department"): Xrm.Attributes.Attribute<string>;
      get(name: "description"): Xrm.Attributes.Attribute<string>;
      get(name: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotfax"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotphone"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
      get(name: "fax"): Xrm.Attributes.Attribute<string>;
      get(name: "firstname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "gendercode"): Xrm.Attributes.OptionSetAttribute<contact_gendercode>;
      get(name: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
      get(name: "jobtitle"): Xrm.Attributes.Attribute<string>;
      get(name: "lastname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "managername"): Xrm.Attributes.Attribute<string>;
      get(name: "managerphone"): Xrm.Attributes.Attribute<string>;
      get(name: "middlename"): Xrm.Attributes.Attribute<string> | null;
      get(name: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
      get(name: "name"): Xrm.Attributes.Attribute<string> | null;
      get(name: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
      get(name: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
      get(name: "parentcustomerid"): XDTForm.LookupAttribute<"account" | "contact">;
      get(name: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<contact_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<contact_preferredcontactmethodcode>;
      get(name: "salutation"): Xrm.Attributes.Attribute<string>;
      get(name: "spousesname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "telephone1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "telephone2"): Xrm.Attributes.Attribute<string>;
      get(name: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
      get(name: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
      get(name: string): null;
      get(): Xrm.Attributes.Attribute[];
      get(index: number): Xrm.Attributes.Attribute;
      get(chooser: (item: Xrm.Attributes.Attribute, index: number) => boolean): Xrm.Attributes.Attribute[];
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "accountrolecode"): XDTForm.OptionSetControl<contact_accountrolecode>;
      get(name: "address1_addresstypecode"): XDTForm.OptionSetControl<contact_address1_addresstypecode>;
      get(name: "address1_city"): Xrm.Controls.StringControl;
      get(name: "address1_country"): Xrm.Controls.StringControl;
      get(name: "address1_freighttermscode"): XDTForm.OptionSetControl<contact_address1_freighttermscode>;
      get(name: "address1_line1"): Xrm.Controls.StringControl;
      get(name: "address1_line2"): Xrm.Controls.StringControl;
      get(name: "address1_line3"): Xrm.Controls.StringControl;
      get(name: "address1_name"): Xrm.Controls.StringControl;
      get(name: "address1_postalcode"): Xrm.Controls.StringControl;
      get(name: "address1_shippingmethodcode"): XDTForm.OptionSetControl<contact_address1_shippingmethodcode>;
      get(name: "address1_stateorprovince"): Xrm.Controls.StringControl;
      get(name: "address1_telephone1"): Xrm.Controls.StringControl;
      get(name: "anniversary"): Xrm.Controls.DateControl;
      get(name: "assistantname"): Xrm.Controls.StringControl;
      get(name: "assistantphone"): Xrm.Controls.StringControl;
      get(name: "birthdate"): Xrm.Controls.DateControl;
      get(name: "contactactivitiesgrid"): XDTForm.SubGridControl<"activitypointer">;
      get(name: "creditlimit"): Xrm.Controls.NumberControl;
      get(name: "creditonhold"): Xrm.Controls.StandardControl;
      get(name: "department"): Xrm.Controls.StringControl;
      get(name: "description"): Xrm.Controls.StringControl;
      get(name: "donotbulkemail"): Xrm.Controls.StandardControl;
      get(name: "donotemail"): Xrm.Controls.StandardControl;
      get(name: "donotfax"): Xrm.Controls.StandardControl;
      get(name: "donotphone"): Xrm.Controls.StandardControl;
      get(name: "donotpostalmail"): Xrm.Controls.StandardControl;
      get(name: "emailaddress1"): Xrm.Controls.StringControl;
      get(name: "familystatuscode"): XDTForm.OptionSetControl<contact_familystatuscode>;
      get(name: "fax"): Xrm.Controls.StringControl;
      get(name: "firstname"): Xrm.Controls.StringControl;
      get(name: "gendercode"): XDTForm.OptionSetControl<contact_gendercode>;
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
      get(name: "managername"): Xrm.Controls.StringControl;
      get(name: "managerphone"): Xrm.Controls.StringControl;
      get(name: "middlename"): Xrm.Controls.StringControl;
      get(name: "mobilephone"): Xrm.Controls.StringControl;
      get(name: "notescontrol"): Xrm.Controls.StringControl;
      get(name: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
      get(name: "parentcustomerid"): XDTForm.LookupControl<"account" | "contact">;
      get(name: "paymenttermscode"): XDTForm.OptionSetControl<contact_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): XDTForm.OptionSetControl<contact_preferredcontactmethodcode>;
      get(name: "salutation"): Xrm.Controls.StringControl;
      get(name: "spousesname"): Xrm.Controls.StringControl;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: "telephone2"): Xrm.Controls.StringControl;
      get(name: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
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
      get(name: "administration"): XDTForm.PageTab<Tabs.administration>;
      get(name: "details"): XDTForm.PageTab<Tabs.details>;
      get(name: "general"): XDTForm.PageTab<Tabs.general>;
      get(name: "notes and activities"): XDTForm.PageTab<Tabs.notesandactivities>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface Information extends XDTForm.FormContextBase<Information.Attributes,Information.Tabs,Information.Controls,Information.QuickViewForms> {
    getAttribute(attributeName: "accountrolecode"): Xrm.Attributes.OptionSetAttribute<contact_accountrolecode>;
    getAttribute(attributeName: "address1_addresstypecode"): Xrm.Attributes.OptionSetAttribute<contact_address1_addresstypecode>;
    getAttribute(attributeName: "address1_city"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_country"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<contact_address1_freighttermscode>;
    getAttribute(attributeName: "address1_line1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line3"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<contact_address1_shippingmethodcode>;
    getAttribute(attributeName: "address1_stateorprovince"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "anniversary"): Xrm.Attributes.DateAttribute;
    getAttribute(attributeName: "assistantname"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "assistantphone"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "birthdate"): Xrm.Attributes.DateAttribute | null;
    getAttribute(attributeName: "creditlimit"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "department"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "description"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotfax"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotphone"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
    getAttribute(attributeName: "fax"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "firstname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "gendercode"): Xrm.Attributes.OptionSetAttribute<contact_gendercode>;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
    getAttribute(attributeName: "jobtitle"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "lastname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "managername"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "managerphone"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "middlename"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
    getAttribute(attributeName: "parentcustomerid"): XDTForm.LookupAttribute<"account" | "contact">;
    getAttribute(attributeName: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<contact_paymenttermscode>;
    getAttribute(attributeName: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<contact_preferredcontactmethodcode>;
    getAttribute(attributeName: "salutation"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "spousesname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "telephone2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "accountrolecode"): XDTForm.OptionSetControl<contact_accountrolecode>;
    getControl(controlName: "address1_addresstypecode"): XDTForm.OptionSetControl<contact_address1_addresstypecode>;
    getControl(controlName: "address1_city"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_country"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_freighttermscode"): XDTForm.OptionSetControl<contact_address1_freighttermscode>;
    getControl(controlName: "address1_line1"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line2"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line3"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_name"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_postalcode"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_shippingmethodcode"): XDTForm.OptionSetControl<contact_address1_shippingmethodcode>;
    getControl(controlName: "address1_stateorprovince"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "anniversary"): Xrm.Controls.DateControl;
    getControl(controlName: "assistantname"): Xrm.Controls.StringControl;
    getControl(controlName: "assistantphone"): Xrm.Controls.StringControl;
    getControl(controlName: "birthdate"): Xrm.Controls.DateControl;
    getControl(controlName: "contactactivitiesgrid"): XDTForm.SubGridControl<"activitypointer">;
    getControl(controlName: "creditlimit"): Xrm.Controls.NumberControl;
    getControl(controlName: "creditonhold"): Xrm.Controls.StandardControl;
    getControl(controlName: "department"): Xrm.Controls.StringControl;
    getControl(controlName: "description"): Xrm.Controls.StringControl;
    getControl(controlName: "donotbulkemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotfax"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotphone"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotpostalmail"): Xrm.Controls.StandardControl;
    getControl(controlName: "emailaddress1"): Xrm.Controls.StringControl;
    getControl(controlName: "familystatuscode"): XDTForm.OptionSetControl<contact_familystatuscode>;
    getControl(controlName: "fax"): Xrm.Controls.StringControl;
    getControl(controlName: "firstname"): Xrm.Controls.StringControl;
    getControl(controlName: "gendercode"): XDTForm.OptionSetControl<contact_gendercode>;
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
    getControl(controlName: "managername"): Xrm.Controls.StringControl;
    getControl(controlName: "managerphone"): Xrm.Controls.StringControl;
    getControl(controlName: "middlename"): Xrm.Controls.StringControl;
    getControl(controlName: "mobilephone"): Xrm.Controls.StringControl;
    getControl(controlName: "notescontrol"): Xrm.Controls.StringControl;
    getControl(controlName: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "parentcustomerid"): XDTForm.LookupControl<"account" | "contact">;
    getControl(controlName: "paymenttermscode"): XDTForm.OptionSetControl<contact_paymenttermscode>;
    getControl(controlName: "preferredcontactmethodcode"): XDTForm.OptionSetControl<contact_preferredcontactmethodcode>;
    getControl(controlName: "salutation"): Xrm.Controls.StringControl;
    getControl(controlName: "spousesname"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone2"): Xrm.Controls.StringControl;
    getControl(controlName: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
