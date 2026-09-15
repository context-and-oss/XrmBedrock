import { XrmQuery, XrmQueryError } from "@delegateas/xrmquery";
import "./styles.css";

const app = document.querySelector<HTMLElement>("#app");

async function start(): Promise<void> {
  if (!app) return;

  try {
    const { UserId } = await XrmQuery.function<{ UserId: string }>("WhoAmI").execute();
    app.textContent = `Connected to Dataverse as ${UserId}.`;
  } catch (error: unknown) {
    app.textContent =
      error instanceof XrmQueryError
        ? `Dataverse request failed (${String(error.status)}): ${error.message}`
        : "Could not connect to the Dataverse Web API.";
  }
}

void start();
