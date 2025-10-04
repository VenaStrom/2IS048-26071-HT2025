import fs from "node:fs";

const templatePath = "PracticeDel1/src/uppgifter/UppgiftX.cs";

const existingUppgifter = fs.readdirSync("PracticeDel1/src/uppgifter");

const uppgiftNumbers = existingUppgifter.map(f => parseInt(f.replace(/\D/g, ""))).filter(n => !isNaN(n));
const nextUppgiftNumber = Math.max(...uppgiftNumbers) + 1;

const newUppgiftPath = `PracticeDel1/src/uppgifter/Uppgift${nextUppgiftNumber}.cs`;

const templateContent = fs.readFileSync(templatePath, "utf-8");
const newUppgiftContent = templateContent.replace(/(Uppgift.?)X/g, `$1${nextUppgiftNumber}`);

fs.writeFileSync(newUppgiftPath, newUppgiftContent);
console.log(`\nCreated ${newUppgiftPath}\n`);