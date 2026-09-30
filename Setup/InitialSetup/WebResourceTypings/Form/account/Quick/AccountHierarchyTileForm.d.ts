declare namespace Form.account.Quick {
  namespace AccountHierarchyTileForm {
    namespace Tabs {
      interface hierarchy extends XDTForm.SectionCollectionBase {
        get(name: "account tile"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
      get(name: "primarycontactid"): XDTForm.LookupControl<"contact">;
      get(name: string): null;
      get(): Xrm.Controls.Control[];
      get(index: number): Xrm.Controls.Control;
      get(chooser: (item: Xrm.Controls.Control, index: number) => boolean): Xrm.Controls.Control[];
    }


    interface Tabs extends XDTForm.TabCollectionBase {
      get(name: "hierarchy"): XDTForm.PageTab<Tabs.hierarchy>;
      get(name: string): null;
      get(): Xrm.Controls.Tab[];
      get(index: number): Xrm.Controls.Tab;
      get(chooser: (item: Xrm.Controls.Tab, index: number) => boolean): Xrm.Controls.Tab[];
    }
  }

  interface AccountHierarchyTileForm extends XDTForm.QuickViewForm<AccountHierarchyTileForm.Tabs,AccountHierarchyTileForm.Controls> {
    getAttribute(attributeName: "ownerid"): XDTForm.LookupAttribute<"systemuser" | "team">;
    getAttribute(attributeName: "primarycontactid"): XDTForm.LookupAttribute<"contact">;
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "ownerid"): XDTForm.LookupControl<"systemuser" | "team">;
    getControl(controlName: "primarycontactid"): XDTForm.LookupControl<"contact">;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
