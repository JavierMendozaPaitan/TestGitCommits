import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            commits: [],
            loading: true
        };
    }

    componentDidMount() {
        this.populateCommitData('PokService');
    }

    render() {
        if (!this.state.loading)
            return this.showTable()
        else
            return (
                <div>Requesting info...</div>
            )
    }

    showTable() {
        return (
            <div>
                <h1 id="tabelLabel" >Git Commit History</h1>
                <p>This is the PokService Project Git Commit History</p>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Author</th>
                            <th>Committer</th>
                            <th>Message</th>
                            <th>Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.state.commits.map(
                                item => {
                                    return (
                                        <tr key={item.commit.node_id}>
                                            <td>{item.commit.author.name}</td>
                                            <td>{item.commit.committer.name}</td>
                                            <td>{item.commit.message}</td>
                                            <td>{item.commit.author.date}</td>
                                        </tr>
                                    );
                                }
                            )
                        }
                    </tbody>
                </table>
            </div>
        );
    }

    async populateCommitData(repo) {
        const response = await fetch('api/GitCommit?repo=' + repo);
        const data = await response.json();
        this.setState({
            commits: data,
            loading: false
        });
    }
}
