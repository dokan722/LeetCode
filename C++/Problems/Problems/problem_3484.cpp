#include "problem_3484.h"

#include <ranges>
#include <unordered_map>


class Spreadsheet {
    std::unordered_map<std::string, int> _cells;
    int GetCellValue(std::string cell)
    {
        if (std::isdigit(cell[0]))
            return std::stoi(cell);
        if (_cells.contains(cell))
            return _cells[cell];
        return 0;
    }
public:
    Spreadsheet(int rows) {
    }

    void setCell(std::string cell, int value) {
        _cells[cell] = value;
    }

    void resetCell(std::string cell) {
        _cells.erase(cell);
    }

    int getValue(std::string formula) {
        auto sep = formula.find('+');
        return GetCellValue(formula.substr(1, sep - 1)) + GetCellValue(formula.substr(sep + 1));
    }
};

bool problem_3484::test() {
    Spreadsheet spreadshit(3);
    if (spreadshit.getValue("=5+7") != 12)
        return false;
    spreadshit.setCell("A1", 10);
    if (spreadshit.getValue("=A1+6") != 16)
        return false;
    spreadshit.setCell("B2", 15);
    if (spreadshit.getValue("=A1+B2") != 25)
        return false;
    spreadshit.resetCell("A1");
    if (spreadshit.getValue("=A1+B2") != 15)
        return false;

    return true;
}
