declare namespace Form.account.Quick {
  namespace SocialProfiles {
    namespace Tabs {
      interface general extends XDTForm.SectionCollectionBase {
        get(name: "SOCIALPROFILES"): Xrm.Controls.Section;
        get(name: string): null;
        get(): Xrm.Controls.Section[];
        get(index: number): Xrm.Controls.Section;
        get(chooser: (item: Xrm.Controls.Section, index: number) => boolean): Xrm.Controls.Section[];
      }
    }


    interface Controls extends XDTForm.ControlCollectionBase {
      get(name: "subgrid_spaccount"): XDTForm.SubGridControl<"socialprofile">;
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

  interface SocialProfiles extends XDTForm.QuickViewForm<SocialProfiles.Tabs,SocialProfiles.Controls> {
    getAttribute(attributeName: string): null;
    getAttribute(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Attributes.Attribute>): Xrm.Attributes.Attribute[];
    getControl(controlName: "subgrid_spaccount"): XDTForm.SubGridControl<"socialprofile">;
    getControl(controlName: string): null;
    getControl(delegateFunction: Xrm.Collection.MatchingDelegate<Xrm.Controls.Control>): Xrm.Controls.Control[];
  }
}
