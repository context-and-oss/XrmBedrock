declare namespace Form.account.Main {
  namespace Information {
    namespace Tabs {
      interface administration extends XDTForm.SectionCollectionBase {
        get(name: "contact methods"): Xrm.Controls.Section;
        get(name: "internal information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface contacts extends XDTForm.SectionCollectionBase {
        get(name: "contacts"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface details extends XDTForm.SectionCollectionBase {
        get(name: "billing information"): Xrm.Controls.Section;
        get(name: "description_2"): Xrm.Controls.Section;
        get(name: "professional information"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface general extends XDTForm.SectionCollectionBase {
        get(name: "account information"): Xrm.Controls.Section;
        get(name: "address"): Xrm.Controls.Section;
        get(name: "description"): Xrm.Controls.Section;
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
      get(name: "accountcategorycode"): Xrm.Attributes.OptionSetAttribute<account_accountcategorycode>;
      get(name: "accountnumber"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_addresstypecode"): Xrm.Attributes.OptionSetAttribute<account_address1_addresstypecode>;
      get(name: "address1_city"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_country"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<account_address1_freighttermscode>;
      get(name: "address1_line1"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line2"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_line3"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_name"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<account_address1_shippingmethodcode>;
      get(name: "address1_stateorprovince"): Xrm.Attributes.Attribute<string>;
      get(name: "address1_telephone1"): Xrm.Attributes.Attribute<string>;
      get(name: "creditlimit"): Xrm.Attributes.NumberAttribute;
      get(name: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
      get(name: "customertypecode"): Xrm.Attributes.OptionSetAttribute<account_customertypecode>;
      get(name: "description"): Xrm.Attributes.Attribute<string>;
      get(name: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotfax"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotphone"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "emailaddress1"): Xrm.Attributes.Attribute<string>;
      get(name: "fax"): Xrm.Attributes.Attribute<string>;
      get(name: "followemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "industrycode"): Xrm.Attributes.OptionSetAttribute<account_industrycode>;
      get(name: "name"): Xrm.Attributes.Attribute<string>;
      get(name: "numberofemployees"): Xrm.Attributes.NumberAttribute;
      get(name: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
      get(name: "ownershipcode"): Xrm.Attributes.OptionSetAttribute<account_ownershipcode>;
      get(name: "parentaccountid"): XDTForm.LookupAttribute<"account">;
      get(name: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<account_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<account_preferredcontactmethodcode>;
      get(name: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
      get(name: "revenue"): Xrm.Attributes.NumberAttribute;
      get(name: "sic"): Xrm.Attributes.Attribute<string>;
      get(name: "telephone1"): Xrm.Attributes.Attribute<string>;
      get(name: "telephone2"): Xrm.Attributes.Attribute<string>;
      get(name: "tickersymbol"): Xrm.Attributes.Attribute<string>;
      get(name: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
      get(name: "websiteurl"): Xrm.Attributes.Attribute<string>;
      get(name: string): null;
      get(): Xrm.Attributes.Attribute[];
      get(index: number): Xrm.Attributes.Attribute;
      get(chooser: (item: Xrm.Attributes.Attribute, index: number) => boolean): Xrm.Attributes.Attribute[];
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "accountactivitiesgrid"): XDTForm.SubGridControl<"activitypointer">;
      get(name: "accountcategorycode"): XDTForm.OptionSetControl<account_accountcategorycode>;
      get(name: "accountContactsGrid"): XDTForm.SubGridControl<"contact">;
      get(name: "accountnumber"): Xrm.Controls.StringControl;
      get(name: "address1_addresstypecode"): XDTForm.OptionSetControl<account_address1_addresstypecode>;
      get(name: "address1_city"): Xrm.Controls.StringControl;
      get(name: "address1_country"): Xrm.Controls.StringControl;
      get(name: "address1_freighttermscode"): XDTForm.OptionSetControl<account_address1_freighttermscode>;
      get(name: "address1_line1"): Xrm.Controls.StringControl;
      get(name: "address1_line2"): Xrm.Controls.StringControl;
      get(name: "address1_line3"): Xrm.Controls.StringControl;
      get(name: "address1_name"): Xrm.Controls.StringControl;
      get(name: "address1_postalcode"): Xrm.Controls.StringControl;
      get(name: "address1_shippingmethodcode"): XDTForm.OptionSetControl<account_address1_shippingmethodcode>;
      get(name: "address1_stateorprovince"): Xrm.Controls.StringControl;
      get(name: "address1_telephone1"): Xrm.Controls.StringControl;
      get(name: "creditlimit"): Xrm.Controls.NumberControl;
      get(name: "creditonhold"): Xrm.Controls.StandardControl;
      get(name: "customertypecode"): XDTForm.OptionSetControl<account_customertypecode>;
      get(name: "description"): Xrm.Controls.StringControl;
      get(name: "donotbulkemail"): Xrm.Controls.StandardControl;
      get(name: "donotemail"): Xrm.Controls.StandardControl;
      get(name: "donotfax"): Xrm.Controls.StandardControl;
      get(name: "donotphone"): Xrm.Controls.StandardControl;
      get(name: "donotpostalmail"): Xrm.Controls.StandardControl;
      get(name: "emailaddress1"): Xrm.Controls.StringControl;
      get(name: "fax"): Xrm.Controls.StringControl;
      get(name: "followemail"): Xrm.Controls.StandardControl;
      get(name: "industrycode"): XDTForm.OptionSetControl<account_industrycode>;
      get(name: "name"): Xrm.Controls.StringControl;
      get(name: "notescontrol"): Xrm.Controls.StringControl;
      get(name: "numberofemployees"): Xrm.Controls.NumberControl;
      get(name: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
      get(name: "ownershipcode"): XDTForm.OptionSetControl<account_ownershipcode>;
      get(name: "parentaccountid"): XDTForm.LookupControl<"account">;
      get(name: "paymenttermscode"): XDTForm.OptionSetControl<account_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): XDTForm.OptionSetControl<account_preferredcontactmethodcode>;
      get(name: "primarycontactid"): XDTForm.LookupControl<"contact">;
      get(name: "revenue"): Xrm.Controls.NumberControl;
      get(name: "sic"): Xrm.Controls.StringControl;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: "telephone2"): Xrm.Controls.StringControl;
      get(name: "tickersymbol"): Xrm.Controls.StringControl;
      get(name: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
      get(name: "websiteurl"): Xrm.Controls.StringControl;
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
      get(name: "contacts"): XDTForm.PageTab<Tabs.contacts>;
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
    getAttribute(attributeName: "accountcategorycode"): Xrm.Attributes.OptionSetAttribute<account_accountcategorycode>;
    getAttribute(attributeName: "accountnumber"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_addresstypecode"): Xrm.Attributes.OptionSetAttribute<account_address1_addresstypecode>;
    getAttribute(attributeName: "address1_city"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_country"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<account_address1_freighttermscode>;
    getAttribute(attributeName: "address1_line1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_line3"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_postalcode"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<account_address1_shippingmethodcode>;
    getAttribute(attributeName: "address1_stateorprovince"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "address1_telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "creditlimit"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "customertypecode"): Xrm.Attributes.OptionSetAttribute<account_customertypecode>;
    getAttribute(attributeName: "description"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotfax"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotphone"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "fax"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "followemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<account_industrycode>;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "numberofemployees"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "ownershipcode"): Xrm.Attributes.OptionSetAttribute<account_ownershipcode>;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<"account">;
    getAttribute(attributeName: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<account_paymenttermscode>;
    getAttribute(attributeName: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<account_preferredcontactmethodcode>;
    getAttribute(attributeName: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
    getAttribute(attributeName: "revenue"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "sic"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "telephone2"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "tickersymbol"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "accountactivitiesgrid"): XDTForm.SubGridControl<"activitypointer">;
    getControl(controlName: "accountcategorycode"): XDTForm.OptionSetControl<account_accountcategorycode>;
    getControl(controlName: "accountContactsGrid"): XDTForm.SubGridControl<"contact">;
    getControl(controlName: "accountnumber"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_addresstypecode"): XDTForm.OptionSetControl<account_address1_addresstypecode>;
    getControl(controlName: "address1_city"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_country"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_freighttermscode"): XDTForm.OptionSetControl<account_address1_freighttermscode>;
    getControl(controlName: "address1_line1"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line2"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_line3"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_name"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_postalcode"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_shippingmethodcode"): XDTForm.OptionSetControl<account_address1_shippingmethodcode>;
    getControl(controlName: "address1_stateorprovince"): Xrm.Controls.StringControl;
    getControl(controlName: "address1_telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "creditlimit"): Xrm.Controls.NumberControl;
    getControl(controlName: "creditonhold"): Xrm.Controls.StandardControl;
    getControl(controlName: "customertypecode"): XDTForm.OptionSetControl<account_customertypecode>;
    getControl(controlName: "description"): Xrm.Controls.StringControl;
    getControl(controlName: "donotbulkemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotfax"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotphone"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotpostalmail"): Xrm.Controls.StandardControl;
    getControl(controlName: "emailaddress1"): Xrm.Controls.StringControl;
    getControl(controlName: "fax"): Xrm.Controls.StringControl;
    getControl(controlName: "followemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "industrycode"): XDTForm.OptionSetControl<account_industrycode>;
    getControl(controlName: "name"): Xrm.Controls.StringControl;
    getControl(controlName: "notescontrol"): Xrm.Controls.StringControl;
    getControl(controlName: "numberofemployees"): Xrm.Controls.NumberControl;
    getControl(controlName: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "ownershipcode"): XDTForm.OptionSetControl<account_ownershipcode>;
    getControl(controlName: "parentaccountid"): XDTForm.LookupControl<"account">;
    getControl(controlName: "paymenttermscode"): XDTForm.OptionSetControl<account_paymenttermscode>;
    getControl(controlName: "preferredcontactmethodcode"): XDTForm.OptionSetControl<account_preferredcontactmethodcode>;
    getControl(controlName: "primarycontactid"): XDTForm.LookupControl<"contact">;
    getControl(controlName: "revenue"): Xrm.Controls.NumberControl;
    getControl(controlName: "sic"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone2"): Xrm.Controls.StringControl;
    getControl(controlName: "tickersymbol"): Xrm.Controls.StringControl;
    getControl(controlName: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
    getControl(controlName: "websiteurl"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
