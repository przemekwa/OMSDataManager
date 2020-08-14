# OMSDataManager

### Szybki start

W katalogu DBscripts tworzymy wszystkie skrypty. Najpierw bazę danych create_selgrosMainDb_db.sql, potem tabele create_selgrosMainDb_tables.sql.
Następnie dla użytkownika SelgrosPGLogin, ustawiamy mapowanie w SSMS na bazę SelgrosMainDB_OMS.
Gdy baza i tabela są gotowe to możemy odpalić program OMSDataManager. 

W klasie Program.cs zmieniamy ścieżki do folderu z plikam z OMS - stała PATH_TO_FOLDER_WITH_CSV_FILE.

Następnie należy zmienić stałą MAX_ROWS aby ustawić domyślną ilość wierszy do wczytania z pliku (wierszy jest bardzo dużo > 1mln, wiec dla testów warto ustawić 100) 

Następnie można program odpalić i wczytać wiersze i testować działanie programu pcb.
