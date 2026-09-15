/**
 * Register templatecompanyname.templateprojectname.FormScripts.Sample.onLoad as a form on-load handler.
 * Replace Xrm.Events.EventContext with a generated Form.<table>.<type>.<name> context where useful.
 */
export function onLoad(executionContext: Xrm.Events.EventContext): void {
  const formContext = executionContext.getFormContext();
  console.debug("Loaded form", formContext.data.entity.getEntityName());
}
