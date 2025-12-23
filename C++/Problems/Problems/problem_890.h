#ifndef PROBLEMS_PROBLEM_890_H
#define PROBLEMS_PROBLEM_890_H

#include "../problem.h"
#include <string>
#include <vector>

class problem_890 : public problem {
public:
    bool test() override;

    std::vector<std::string> findAndReplacePattern(std::vector<std::string>& words, std::string pattern);
private:
    std::string encode(std::string word);
};

#endif //PROBLEMS_PROBLEM_890_H