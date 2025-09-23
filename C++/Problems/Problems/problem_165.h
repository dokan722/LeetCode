#ifndef PROBLEM_165_H
#define PROBLEM_165_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_165: public problem {
public:
    bool test() override;

    int compareVersion(std::string version1, std::string version2);
private:
    std::vector<int> splitToInts(const std::string& s);
};



#endif //PROBLEM_165_H
