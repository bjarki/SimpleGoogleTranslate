SimpleGoogleTranslate
=====================

A simple Google translate wrapper for .Net


When using the Googel Translate "Server" it will change casing of words and add spaces in weird places.

## TODO List
- `bjarki.` -> `bjarki .`
- `bjarki: stuff` -> `bjarki : stuff`
- `({0}:{1})` -> `( { 0 } : { 1 } )`
- `Sort &Ascending` -> `Sort` it will skip `&`
- `bla-bla` -> `bla - bla`
- `Filter=` -> `Filter =`
- `stuff. stuff` -> `stuff . stuff`
- Google translate API will also trim spaces so `text ` -> `text`
