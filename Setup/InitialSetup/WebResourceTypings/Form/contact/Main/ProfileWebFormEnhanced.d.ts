declare namespace Form.contact.Main {
  namespace ProfileWebFormEnhanced {
    namespace Tabs {
    }

    interface Attributes extends XDTForm.AttributeCollectionBase {
      get(name: "adx_organizationname"): Xrm.Attributes.Attribute<string>;
      get(name: "adx_publicprofilecopy"): Xrm.Attributes.Attribute<string>;
      get(name: "birthdate"): Xrm.Attributes.DateAttribute | null;
      get(name: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
      get(name: "firstname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
      get(name: "jobtitle"): Xrm.Attributes.Attribute<string>;
      get(name: "lastname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "middlename"): Xrm.Attributes.Attribute<string> | null;
      get(name: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
      get(name: "mspp_userpreferredlcid"): Xrm.Attributes.OptionSetAttribute<powerpagelanguages>;
      get(name: "name"): Xrm.Attributes.Attribute<string> | null;
      get(name: "nickname"): Xrm.Attributes.Attribute<string>;
      get(name: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
      get(name: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
      get(name: "spousesname"): Xrm.Attributes.Attribute<string> | null;
      get(name: "telephone1"): Xrm.Attributes.Attribute<string> | null;
      get(name: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
      get(name: string): null;
      get(): Xrm.Attributes.Attribute[];
      get(index: number): Xrm.Attributes.Attribute;
      get(chooser: (item: Xrm.Attributes.Attribute, index: number) => boolean): Xrm.Attributes.Attribute[];
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "adx_organizationname"): Xrm.Controls.StringControl;
      get(name: "adx_publicprofilecopy"): Xrm.Controls.StringControl;
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
      get(name: "mspp_userpreferredlcid"): XDTForm.OptionSetControl<powerpagelanguages>;
      get(name: "nickname"): Xrm.Controls.StringControl;
      get(name: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
      get(name: "telephone1"): Xrm.Controls.StringControl;
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
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface ProfileWebFormEnhanced extends XDTForm.FormContextBase<ProfileWebFormEnhanced.Attributes,ProfileWebFormEnhanced.Tabs,ProfileWebFormEnhanced.Controls,ProfileWebFormEnhanced.QuickViewForms> {
    getAttribute(attributeName: "adx_organizationname"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "adx_publicprofilecopy"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "birthdate"): Xrm.Attributes.DateAttribute | null;
    getAttribute(attributeName: "emailaddress1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "familystatuscode"): Xrm.Attributes.OptionSetAttribute<contact_familystatuscode> | null;
    getAttribute(attributeName: "firstname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "industrycode"): Xrm.Attributes.OptionSetAttribute<number> | null;
    getAttribute(attributeName: "jobtitle"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "lastname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "middlename"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "mobilephone"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "mspp_userpreferredlcid"): Xrm.Attributes.OptionSetAttribute<powerpagelanguages>;
    getAttribute(attributeName: "name"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "nickname"): Xrm.Attributes.Attribute<string>;
    getAttribute(attributeName: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "parentaccountid"): XDTForm.LookupAttribute<string> | null;
    getAttribute(attributeName: "spousesname"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "telephone1"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: "websiteurl"): Xrm.Attributes.Attribute<string> | null;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "adx_organizationname"): Xrm.Controls.StringControl;
    getControl(controlName: "adx_publicprofilecopy"): Xrm.Controls.StringControl;
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
    getControl(controlName: "mspp_userpreferredlcid"): XDTForm.OptionSetControl<powerpagelanguages>;
    getControl(controlName: "nickname"): Xrm.Controls.StringControl;
    getControl(controlName: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "telephone1"): Xrm.Controls.StringControl;
    getControl(controlName: "websiteurl"): Xrm.Controls.StringControl;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
