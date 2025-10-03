import fs from "node:fs";

const templatePath = "PracticeV41/src/uppgifter/UppgiftX.cs";

const existingUppgifter = fs.readdirSync("PracticeV41/src/uppgifter");

const uppgiftNumbers = existingUppgifter.map(f => parseInt(f.replace(/\D/g, "")));
const nextUppgiftNumber = Math.max(...uppgiftNumbers) + 1;

const newUppgiftPath = `PracticeV41/src/uppgifter/Uppgift${nextUppgiftNumber}.cs`;

const templateContent = fs.readFileSync(templatePath, "utf-8");
const newUppgiftContent = templateContent.replaceAll(/Uppgift.?X/, `Uppgift${nextUppgiftNumber}`);

fs.writeFileSync(newUppgiftPath, newUppgiftContent);
console.log(`Created ${newUppgiftPath}`);