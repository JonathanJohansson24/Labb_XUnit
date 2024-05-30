# Kalkylatorapplikation

## Beskrivning
En enkel miniräknarapplikation som kan utföra addition, subtraktion, division och multiplikation. Applikationen kan spara och visa en historik över utförda beräkningar.

## Acceptanstester

### Acceptanstest 1: Addition

1. Öppna applikationen.
2. Välj "addition" som operation genom att skriva "addition" och tryck Enter.
3. Ange det första talet: skriv "5" och tryck Enter.
4. Ange det andra talet: skriv "3" och tryck Enter.
5. Applikationen skriver ut "Result: 8".
6. Användaren ska kunna välja att fortsätta eller avsluta applikationen.

### Acceptanstest 2: Subtraktion

1. Öppna applikationen.
2. Välj "subtraktion" som operation genom att skriva "subtraktion" och tryck Enter.
3. Ange det första talet: skriv "10" och tryck Enter.
4. Ange det andra talet: skriv "4" och tryck Enter.
5. Applikationen skriver ut "Result: 6".
6. Användaren ska kunna välja att fortsätta eller avsluta applikationen.

### Acceptanstest 3: Division med historik

1. Öppna applikationen.
2. Välj "division" som operation genom att skriva "division" och tryck Enter.
3. Ange det första talet: skriv "20" och tryck Enter.
4. Ange det andra talet: skriv "4" och tryck Enter.
5. Applikationen skriver ut "Result: 5".
6. Användaren ska kunna välja att se historiken genom att skriva "ja" när frågan "Vill du se loggen över uträkningar som gjorts?" visas.
7. Applikationen skriver ut historiken som innehåller "20 / 4 = 5".

## Enhetstester

Enhetstester finns implementerade med XUnit och testar olika delar av applikationen. Se `CalculatorTests.cs` för mer detaljer.
