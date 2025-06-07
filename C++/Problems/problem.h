#ifndef IPROBLEM_H
#define IPROBLEM_H


class problem {
public:
    virtual ~problem() = default;

    virtual bool test() = 0;
};

#endif
