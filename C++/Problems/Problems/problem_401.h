#ifndef PROBLEMS_PROBLEM_401_H
#define PROBLEMS_PROBLEM_401_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_401 : public problem {
public:
    bool test() override;

    std::vector<std::string> readBinaryWatch(int turnedOn);
private:
    void watchRec(int curr, int limit, int start, int minutes, int hours, std::vector<int>& values, std::vector<std::string>& result);
};

#endif //PROBLEMS_PROBLEM_401_H