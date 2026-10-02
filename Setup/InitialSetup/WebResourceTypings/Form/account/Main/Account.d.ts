declare namespace Form.account.Main {
  namespace Account {
    namespace Tabs {
      interface DETAILS_TAB extends XDTForm.SectionCollectionBase {
        get(name: "BILLING"): Xrm.Controls.Section;
        get(name: "COMPANY_PROFILE"): Xrm.Controls.Section;
        get(name: "CONTACT_PREFERENCES"): Xrm.Controls.Section;
        get(name: "ChildAccounts"): Xrm.Controls.Section;
        get(name: "DETAILS_TAB_section_6"): Xrm.Controls.Section;
        get(name: "SHIPPING"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }

      interface SUMMARY_TAB extends XDTForm.SectionCollectionBase {
        get(name: "ACCOUNT_INFORMATION"): Xrm.Controls.Section;
        get(name: "ADDRESS"): Xrm.Controls.Section;
        get(name: "MapSection"): Xrm.Controls.Section;
        get(name: "SOCIAL_PANE_TAB"): Xrm.Controls.Section;
        get(name: "SUMMARY_TAB_section_6"): Xrm.Controls.Section;
        get(name: "Summary_section_6"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }

    interface Attributes extends XDTForm.AttributeCollectionBase {
      get(name: "address1_city"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_composite"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_country"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<account_address1_freighttermscode>;
      get(name: "address1_line1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_line2"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_line3"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_postalcode"): Xrm.Attributes.Attribute<string> | null;
      get(name: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<account_address1_shippingmethodcode>;
      get(name: "address1_stateorprovince"): Xrm.Attributes.Attribute<string> | null;
      get(name: "creditlimit"): Xrm.Attributes.NumberAttribute;
      get(name: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
      get(name: "description"): Xrm.Attributes.Attribute<string>;
      get(name: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotfax"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotphone"): Xrm.Attributes.Attribute<boolean>;
      get(name: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "fax"): Xrm.Attributes.Attribute<string>;
      get(name: "followemail"): Xrm.Attributes.Attribute<boolean>;
      get(name: "industrycode"): Xrm.Attributes.OptionSetAttribute<account_industrycode>;
      get(name: "name"): Xrm.Attributes.Attribute<string>;
      get(name: "ownershipcode"): Xrm.Attributes.OptionSetAttribute<account_ownershipcode>;
      get(name: "parentaccountid"): XDTForm.LookupAttribute<"account">;
      get(name: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<account_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<account_preferredcontactmethodcode>;
      get(name: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
      get(name: "sic"): Xrm.Attributes.Attribute<string>;
      get(name: "telephone1"): Xrm.Attributes.Attribute<string>;
      get(name: "tickersymbol"): Xrm.Attributes.Attribute<string>;
      get(name: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
      get(name: "websiteurl"): Xrm.Attributes.Attribute<string>;
      get(name: string): null;
      get(): Xrm.Attributes.Attribute[];
      get(index: number): Xrm.Attributes.Attribute;
      get(chooser: (item: Xrm.Attributes.Attribute, index: number) => boolean): Xrm.Attributes.Attribute[];
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "ActionCards"): Xrm.Controls.Control;
      get(name: "address1_composite"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_city"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_country"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_line1"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_line2"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_line3"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_postalcode"): Xrm.Controls.StringControl | null;
      get(name: "address1_composite_compositionLinkControl_address1_stateorprovince"): Xrm.Controls.StringControl | null;
      get(name: "address1_freighttermscode"): XDTForm.OptionSetControl<account_address1_freighttermscode>;
      get(name: "address1_shippingmethodcode"): XDTForm.OptionSetControl<account_address1_shippingmethodcode>;
      get(name: "ChildAccounts"): XDTForm.SubGridControl<"account">;
      get(name: "Contacts"): XDTForm.SubGridControl<"contact">;
      get(name: "creditlimit"): Xrm.Controls.NumberControl;
      get(name: "creditonhold"): Xrm.Controls.StandardControl;
      get(name: "description"): Xrm.Controls.StringControl;
      get(name: "donotbulkemail"): Xrm.Controls.StandardControl;
      get(name: "donotemail"): Xrm.Controls.StandardControl;
      get(name: "donotfax"): Xrm.Controls.StandardControl;
      get(name: "donotphone"): Xrm.Controls.StandardControl;
      get(name: "donotpostalmail"): Xrm.Controls.StandardControl;
      get(name: "fax"): Xrm.Controls.StringControl;
      get(name: "followemail"): Xrm.Controls.StandardControl;
      get(name: "industrycode"): XDTForm.OptionSetControl<account_industrycode>;
      get(name: "mapcontrol"): Xrm.Controls.Control;
      get(name: "name"): Xrm.Controls.StringControl;
      get(name: "notescontrol"): Xrm.Controls.StringControl;
      get(name: "ownershipcode"): XDTForm.OptionSetControl<account_ownershipcode>;
      get(name: "parentaccountid"): XDTForm.LookupControl<"account">;
      get(name: "paymenttermscode"): XDTForm.OptionSetControl<account_paymenttermscode>;
      get(name: "preferredcontactmethodcode"): XDTForm.OptionSetControl<account_preferredcontactmethodcode>;
      get(name: "primarycontactid"): XDTForm.LookupControl<"contact">;
      get(name: "sic"): Xrm.Controls.StringControl;
      get(name: "telephone1"): Xrm.Controls.StringControl;
      get(name: "tickersymbol"): Xrm.Controls.StringControl;
      get(name: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
      get(name: "websiteurl"): Xrm.Controls.StringControl;
      get(name: string): null;
      get(): Xrm.Controls.Control[];
      get(index: number): Xrm.Controls.Control;
      get(chooser: (item: Xrm.Controls.Control, index: number) => boolean): Xrm.Controls.Control[];
    }

    interface QuickViewForms extends XDTForm.QuickViewFormCollectionBase {
      get(name: "contactquickform"): Form.contact.Quick.accountcontactcard;
      get(name: string): null;
      get(): XDTForm.QuickViewFormBase[];
      get(index: number): XDTForm.QuickViewFormBase;
      get(chooser: (item: XDTForm.QuickViewFormBase, index: number) => boolean): XDTForm.QuickViewFormBase[];
    }


    interface Tabs extends XDTForm.TabCollectionBase {
      get(name: "DETAILS_TAB"): XDTForm.PageTab<Tabs.DETAILS_TAB>;
      get(name: "SUMMARY_TAB"): XDTForm.PageTab<Tabs.SUMMARY_TAB>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface Account extends XDTForm.FormContextBase<Account.Attributes,Account.Tabs,Account.Controls,Account.QuickViewForms> {
    getAttribute(attributeName: "address1_city"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_composite"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_country"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_freighttermscode"): Xrm.Attributes.OptionSetAttribute<account_address1_freighttermscode>;
    getAttribute(attributeName: "address1_line1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_line2"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_line3"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_postalcode"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "address1_shippingmethodcode"): Xrm.Attributes.OptionSetAttribute<account_address1_shippingmethodcode>;
    getAttribute(attributeName: "address1_stateorprovince"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "creditlimit"): Xrm.Attributes.NumberAttribute;
    getAttribute(attributeName: "creditonhold"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "description"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "donotbulkemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotfax"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotphone"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "donotpostalmail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "fax"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "followemail"): Xrm.Attributes.Attribute<boolean>;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<account_industrycode>;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "ownershipcode"): Xrm.Attributes.OptionSetAttribute<account_ownershipcode>;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<"account">;
    getAttribute(attributeName: "paymenttermscode"): Xrm.Attributes.OptionSetAttribute<account_paymenttermscode>;
    getAttribute(attributeName: "preferredcontactmethodcode"): Xrm.Attributes.OptionSetAttribute<account_preferredcontactmethodcode>;
    getAttribute(attributeName: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
    getAttribute(attributeName: "sic"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "tickersymbol"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "transactioncurrencyid"): XDTForm.LookupAttribute<"transactioncurrency">;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "ActionCards"): Xrm.Controls.Control;
    getControl(controlName: "address1_composite"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_city"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_country"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_line1"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_line2"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_line3"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_postalcode"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_composite_compositionLinkControl_address1_stateorprovince"): Xrm.Controls.StringControl | null;
    getControl(controlName: "address1_freighttermscode"): XDTForm.OptionSetControl<account_address1_freighttermscode>;
    getControl(controlName: "address1_shippingmethodcode"): XDTForm.OptionSetControl<account_address1_shippingmethodcode>;
    getControl(controlName: "ChildAccounts"): XDTForm.SubGridControl<"account">;
    getControl(controlName: "Contacts"): XDTForm.SubGridControl<"contact">;
    getControl(controlName: "creditlimit"): Xrm.Controls.NumberControl;
    getControl(controlName: "creditonhold"): Xrm.Controls.StandardControl;
    getControl(controlName: "description"): Xrm.Controls.StringControl;
    getControl(controlName: "donotbulkemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotfax"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotphone"): Xrm.Controls.StandardControl;
    getControl(controlName: "donotpostalmail"): Xrm.Controls.StandardControl;
    getControl(controlName: "fax"): Xrm.Controls.StringControl;
    getControl(controlName: "followemail"): Xrm.Controls.StandardControl;
    getControl(controlName: "industrycode"): XDTForm.OptionSetControl<account_industrycode>;
    getControl(controlName: "mapcontrol"): Xrm.Controls.Control;
    getControl(controlName: "name"): Xrm.Controls.StringControl;
    getControl(controlName: "notescontrol"): Xrm.Controls.StringControl;
    getControl(controlName: "ownershipcode"): XDTForm.OptionSetControl<account_ownershipcode>;
    getControl(controlName: "parentaccountid"): XDTForm.LookupControl<"account">;
    getControl(controlName: "paymenttermscode"): XDTForm.OptionSetControl<account_paymenttermscode>;
    getControl(controlName: "preferredcontactmethodcode"): XDTForm.OptionSetControl<account_preferredcontactmethodcode>;
    getControl(controlName: "primarycontactid"): XDTForm.LookupControl<"contact">;
    getControl(controlName: "sic"): Xrm.Controls.StringControl;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "tickersymbol"): Xrm.Controls.StringControl;
    getControl(controlName: "transactioncurrencyid"): XDTForm.LookupControl<"transactioncurrency">;
    getControl(controlName: "websiteurl"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
