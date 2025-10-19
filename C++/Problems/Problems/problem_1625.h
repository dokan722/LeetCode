#ifndef PROBLEM_1625_H
#define PROBLEM_1625_H


#include <set>

#include "../problem.h"
#include <string>
#include <vector>

class problem_1625 : public problem {
public:
    bool test() override;

    std::string findLexSmallestString(std::string s, int a, int b);
private:
    void findRec(std::string s, int a, int b, std::set<std::string>& present);
};



#endif //PROBLEM_1625_H
