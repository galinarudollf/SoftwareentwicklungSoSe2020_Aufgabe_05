# SoftwareentwicklungSoSe2020_Aufgabe_04

## Bearbeitungzeit

16. Juni - 30. Juni 2020

## Idee der Übung

Mit dem Aufgabenblatt sollen Ihre Fähigkeiten beim objektorientierten Entwurf und der entsprechenden Implementierung weiter trainiert werden. Achten Sie dabei darauf:

+ die Klassen in einzelnen Dateien zu speichern
+ die Signaturen ihrer festzulegen, in die Dateien zu integrieren und dann eine Version ohne funktionalität ins repositorium zu übertragen
+ die Implementierungen in Branches zu organisieren
+ über Issues die Zuständigkeiten bei Ihrer Implementierung zu klären und die Issues mit entsprechenden Commits zu schließen.

## 1. Nullable Types

Schreiben Sie ein Programm, das den Sperrmechanismus eines Smartphones modelliert.

+ Erstellen Sie bitte zunächst eine Klasse `Smartphone`.

+ Fügen Sie ihr ein privates Feld namens `Pin` hinzu. Es soll Integerzahlen speichern können, aber auch den Wert `null` zulassen, der den "Nicht-gesetzt"-Zustand repräsentiert.

+ Nach Instanziierung des Smartphones soll zunächst keine PIN gesetzt sein.

+ Fügen Sie der `Smartphone`-Klasse bitte eine private Methode zur Authentifizierung hinzu. Sie fragt den Benutzer nach einer PIN (wenn gesetzt), die auf der Konsole eingegeben werden soll. Wenn die PIN stimmt, gibt die Methode `true` zurück. Nach einer Fehleingabe hat der Nutzer weitere Versuche, jedoch insgesamt maximal drei. Anschließend wird das Smartphone permanent gesperrt und lässt keine Authentifizierung mehr zu. In diesem Fall gibt die Methode `false` zurück.

+ Die richtige Eingabe der PIN (z. B. nach zwei Fehlversuchen) soll die Anzahl der Fehlversuche auf 0 zurücksetzen.

+ Fügen Sie der `Smartphone`-Klasse eine öffentliche Methode zum Ändern der PIN hinzu. Dafür wird
der Nutzer zunächst authentifiziert und darf anschließend einen neuen Wert auf der Konsole eingeben. Im Falle einer leeren Eingabe wird die PIN als "nicht gesetzt" markiert.

+ Testen Sie das Verhalten der `Smartphone`-Klasse in der `Main`-Methode. Sie können auch weitere Methoden hinzufügen, die die Authentifizierung des Benutzers erfordern.


## 2. Vererbung, abstracte Klassen, Interfaces, virtuelle Methoden, Überschreibung

Schreiben Sie ein Programm, das in der Lage ist, eine Haustierverwaltung zu realisieren.

+ Erstellen Sie bitte zunächst eine abstrakte Klasse `Pet`, die als Basis der Klassenhierarchie dienen soll. Jedes Haustier hat einen Namen ( `get` -/ `set` -Property) und will gepflegt werden (abstrakte
Methode `Attend()`).

Die Haustiere werden in Säugetiere (Klasse `Mammal`) und Fische (Klasse `Fish`) unterteilt.

+ Legen Sie bitte die entsprechenden Klassen an.
+ Säugetiere verfügen über eine Methode zur Fortbewegung ( `Move()` ), Fische analog über eine
Methode zum Schwimmen ( `Swim()` ). Beide Methoden sind abstrakt.
+ Für alle Fische ist die Pflege einheitlich: Das Wasser muss gewechselt werden. Bitte implementieren Sie die Methode `Attend()` entsprechend (Konsolenausgabe).

Goldfische und Guppys sind spezielle Fische.

+ Legen Sie bitte die entsprechenden Klassen an.
+ Goldfische schwimmen bekanntermaßen immer im Kreis, Guppys nur vor und zurück. Bitte
implementieren Sie passende `Swim()` -Methoden.

Katzen und Kaninchen sind spezielle Säugetiere.

+ Legen Sie bitte die entsprechenden Klassen an.
+ Zur Pflege von Katzen bürstet man ihr Fell. Kaninchen pflegt man durch Ausmisten ihres Stalls. Bitte
implementieren Sie passende `Attend()` -Methoden.
+ Katzen bewegen sich fort, indem sie schleichen, während Kaninchen bevorzugt hoppeln. Bitte
implementieren Sie passende `Move()` -Methoden.

Haustiere können einen Besitzer haben.

+ Fügen Sie der `Pet`-Klasse eine entsprechende String-Property (oder alternativ ein
`public readonly` -Feld) hinzu.
+ Der Wert wird einmalig bei der Instanziierung festgelegt (bzw. auf `null` gesetzt) und kann
anschließend nicht mehr geändert werden. Erstellen Sie einen passenden Konstruktor.
+ Fügen Sie den abgeleiteten Klassen ebenfalls Konstruktoren hinzu. Bitte beachten Sie dabei, dass
Katzen grundsätzlich keinen Besitzer haben ( `null` ).

Einige Haustiere lassen sich streicheln.

+ Erstellen Sie bitte zunächst ein Interface (z. B. `IStrokeable` ), mit dem sich streichelbare Haustiere auszeichnen lassen. Fügen Sie eine passende Methodendeklaration ( `Stroke()` ) hinzu.
+ Alle Säugetiere sowie Goldfische können gestreichelt werden.
+ Wenn man Katzen streichelt, schnurren sie. Leider beißen sie in einem von fünf Fällen anschließend grundlos zu. Bitte implementieren Sie dieses Verhalten.
+ Goldfische, die keinen Besitzer haben, schwimmen weg, wenn man sie streichelt.

Haustiere sollten auf einfache Weise mithilfe der Konsole ausgegeben werden können.

+ Überschreiben Sie die `ToString` -Methode in den vier nicht-abstrakten Tierklassen und geben Sie jeweils Art, Name und Besitzer (nicht bei Katzen) in einer formatierten Zeichenkette zurück.

Testen Sie Ihre Tierklassen in der Main -Methode.

+ Legen Sie einen Garten (Liste mit Säugetieren) und ein Aquarium (Liste mit Fischen) an. Füllen Sie sie mit Katzen, Kaninchen, Goldfischen und Guppys.
+ Geben Sie Ihre Haustiere auf der Konsole aus und lassen Sie sie schwimmen bzw. sich bewegen.
+ Kombinieren Sie Garten und Aquarium in einer `Pet` -Liste namens `Zoo`. Pflegen Sie den gesamten Zoo.
+ Streicheln Sie diejenigen Haustiere im Zoo, die das IStrokeable -Interface implementieren (Tipp: `as` -Operator nutzen).
+ Welches objektorientierte Konzept ermöglicht es, dass beim Zugriff über den Basisklassen-Typ die korrekten Methodenimplementierungen aus den Unterklassen aufgerufen werden?

## 3. UML Darstellung zu Aufgabe 2 

Generieren Sie wiederum ein UML Diagramm aus Aufgabe 2. Sie können dies manuell oder unter zu Hilfenahme der Actions, die in Aufgabenblatt 4 zum Einsatz kamen tuen.
